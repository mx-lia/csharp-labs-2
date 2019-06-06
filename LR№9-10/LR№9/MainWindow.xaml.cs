using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Library.DataModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.Entity;

namespace LR_9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataGrid currentDg;
        UnitOfWork unitOfWork;

        public MainWindow()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            authors.Visibility = Visibility.Hidden;
            books.Visibility = Visibility.Hidden;
            switch ((((ComboBox)sender).SelectedItem as ComboBoxItem).Content)
            {
                case "Books":
                    currentDg = books;
                    currentDg.DataContext = (from b in unitOfWork.Books.GetList() select b).ToList();
                    break;
                case "Authors":
                    currentDg = authors;
                    currentDg.DataContext = (from b in unitOfWork.Authors.GetList() select b).ToList();
                    break;
            }
            currentDg.Visibility = Visibility.Visible;
            add.IsEnabled = true;
        }

        private void DeleteRow_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (currentDg == authors)
            {
                unitOfWork.Authors.Delete((Author)(button.DataContext));
                unitOfWork.Save();
                currentDg.DataContext = (from b in unitOfWork.Authors.GetList() select b).ToList();
            }
            else
            {
                unitOfWork.Books.Delete((Book)(button.DataContext));
                unitOfWork.Save();
                currentDg.DataContext = (from b in unitOfWork.Books.GetList() select b).ToList();
            }
        }

        private void SaveRow_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (currentDg == authors)
                unitOfWork.Authors.Update((Author)button.DataContext);
            else
                unitOfWork.Books.Update((Book)button.DataContext);
            unitOfWork.Save();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (currentDg == authors)
            {
                AuthorAdd authorWindow = new AuthorAdd();
                authorWindow.ShowDialog();
                if(authorWindow.DialogResult == true)
                {
                    unitOfWork.Authors.Create(new Author { Name = authorWindow.name.Text, Birthday = authorWindow.birthday.SelectedDate.GetValueOrDefault() });
                    unitOfWork.Save();
                    currentDg.DataContext = (from b in unitOfWork.Authors.GetList() select b).ToList();
                }
            }
            else
            {
                BookAdd bookWindow = new BookAdd();
                bookWindow.ShowDialog();
                if(bookWindow.DialogResult == true)
                {
                    unitOfWork.Books.Create(new Book { Title = bookWindow.title.Text, Year = int.Parse(bookWindow.year.Text), Author = unitOfWork.Authors.GetItem((int)bookWindow.author.SelectedValue)});
                    unitOfWork.Save();
                    currentDg.DataContext = (from b in unitOfWork.Books.GetList() select b).ToList();
                }
            }          
        }
    }
}
