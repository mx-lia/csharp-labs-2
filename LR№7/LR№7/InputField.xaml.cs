using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR_7
{
    /// <summary>
    /// Логика взаимодействия для InputField.xaml
    /// </summary>
    public partial class InputField : UserControl
    {
        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register("ImageSource", typeof(Uri), typeof(InputField),
            new PropertyMetadata(new PropertyChangedCallback(ImageSourceChanged)));

        public InputField()
        {
            InitializeComponent();
        }

        public Uri ImageSource
        {
            get { return (Uri)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        private static void ImageSourceChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs args)
        {
            InputField obj = (InputField)depObj;
            Image image = obj.image;
            image.Source = new BitmapImage((Uri)args.NewValue);
        }
    }
}
