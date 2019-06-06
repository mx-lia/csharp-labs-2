using Library.DataModel;
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
using System.Windows.Shapes;

namespace LR_9
{
    /// <summary>
    /// Логика взаимодействия для AuthorAdd.xaml
    /// </summary>
    public partial class AuthorAdd : Window
    {
        LibraryContext libraryContext = new LibraryContext();

        public AuthorAdd()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e) => DialogResult = true;
    }
}
