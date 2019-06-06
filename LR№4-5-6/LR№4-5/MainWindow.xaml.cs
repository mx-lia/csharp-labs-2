using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;
using System.Windows.Resources;
using ColorPickerWPF;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace LR_4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MenuItem> recentFiles = new ObservableCollection<MenuItem>();

        public MainWindow()
        {
            InitializeComponent();

            StreamResourceInfo sri = Application.GetResourceStream(new Uri("icons/pointer.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            Cursor = customCursor;

            textArea.AddHandler(DragOverEvent, new DragEventHandler(DragItem), true);
            textArea.AddHandler(DropEvent, new DragEventHandler(DropItem), true);

            ResourceDictionary resourceDict = Application.LoadComponent(new Uri("Light.xaml", UriKind.Relative)) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);

            recentFiles.CollectionChanged += RecentFiles_CollectionChanged;
        }

        private void RecentFiles_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            recentFiles_MenuItem.ItemsSource = recentFiles;
            foreach (MenuItem item in recentFiles_MenuItem.Items)
            {
                item.Click += (object sender1, RoutedEventArgs e1) => {
                    FileStream fileStream = new FileStream(item.Header.ToString(), FileMode.Open);
                    TextRange range = new TextRange(textArea.Document.ContentStart, textArea.Document.ContentEnd);
                    range.Load(fileStream, DataFormats.Rtf);
                    Title = fileStream.Name;
                    fileStream.Close();
                };
            }
        }

        private void DragItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effects = DragDropEffects.All;
            else
                e.Effects = DragDropEffects.None;
            e.Handled = false;
        }

        private void DropItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(docPath[0]))
                {
                    try
                    {
                        TextRange range = new TextRange(textArea.Document.ContentStart, textArea.Document.ContentEnd);
                        FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                        range.Load(fStream, DataFormats.Rtf);
                        fStream.Close();
                        Title = docPath[0];
                        MenuItem menuItem = new MenuItem();
                        menuItem.Header = docPath[0];
                        recentFiles.Add(menuItem);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(TryFindResource("_Error").ToString());
                    }
                }
            }
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(TryFindResource("_Save?").ToString(), TryFindResource("_SaveName").ToString(), MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                SaveCommand_Executed(sender, e);
            }
            textArea.Document.Blocks.Clear();
            Title = "Text Editor";
        }

        private void OpenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Open);
                TextRange range = new TextRange(textArea.Document.ContentStart, textArea.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Rtf);
                Title = fileStream.Name;
            }
            MenuItem menuItem = new MenuItem();
            menuItem.Header = dlg.FileName;
            recentFiles.Add(menuItem);
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Rich Text Format (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == true)
            {
                FileStream fileStream = new FileStream(dlg.FileName, FileMode.Create);
                TextRange range = new TextRange(textArea.Document.ContentStart, textArea.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Rtf);
                Title = fileStream.Name;
            }
        }

        private void CopyCommand_Executed(object sender, ExecutedRoutedEventArgs e) => textArea.Copy();

        private void PasteCommand_Executed(object sender, ExecutedRoutedEventArgs e) => textArea.Paste();

        private void UndoCommand_Executed(object sender, ExecutedRoutedEventArgs e) => textArea.Undo();

        private void RedoCommand_Executed(object sender, ExecutedRoutedEventArgs e) => textArea.Redo();

        private void TextArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            int symbols = 0, lines = 0;
            TextRange textRange = new TextRange(textArea.Document.ContentStart, textArea.Document.ContentEnd);
            foreach (char c in textRange.Text)
            {
                if (!c.Equals('\n') && (int)c != 13)
                {
                    symbols++;
                }
                else if (c.Equals('\n'))
                {
                    lines++;
                }
            }
            this.symbols.Content = symbols;
            this.lines.Content = lines;
        }

        private void ThemeChange_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri((sender as MenuItem).Name + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Language_Click(object sender, RoutedEventArgs e)
        {
            Resources = new ResourceDictionary();
            switch ((sender as Control).Name)
            {
                case "en":
                    Resources.Source = new Uri("pack://application:,,,/langEN.xaml");
                    break;
                case "ru":
                    Resources.Source = new Uri("pack://application:,,,/langRU.xaml");
                    break;
            }
        }

        public void ApplySelection(DependencyProperty property, object value)
        {
            if (value != null && textArea != null)
            {
                textArea.Selection.ApplyPropertyValue(property, value);
            }
        }

        private void SelectionChanged(object sender, RoutedEventArgs e)
        {
            switch((sender as Control).Name)
            {
                case "fonts":
                    ApplySelection(FontFamilyProperty, (fonts.SelectedItem as ComboBoxItem).Content);
                    break;
                case "fontSize":
                    ApplySelection(FontSizeProperty, fontSize.Text);
                    break;
            }
        }

        private void Color_Click(object sender, RoutedEventArgs e)
        {
            bool ok = ColorPickerWindow.ShowDialog(out Color color);
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString(color.ToString());
            ApplySelection(ForegroundProperty, brush);
        }
    }
}
