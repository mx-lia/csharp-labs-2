using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace LR_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString;
        DataSet ds;
        SqlDataAdapter adapter;
        string sqlQuery = "select * from ";
        DataGrid currentDg;
        SqlCommandBuilder commandBuilder;
        int pageSize = 2;
        int pageNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        private void FillGrid(string sql, DataGrid dataGrid)
        {
            currentDg.CanUserAddRows = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql + " ORDER BY " + ((Binding)currentDg.Columns[0].ClipboardContentBinding).Path.Path + " OFFSET((" + pageNumber + ") * " + pageSize + ") " + "ROWS FETCH NEXT " + pageSize + " ROWS ONLY", connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGrid.ItemsSource = ds.Tables[0].DefaultView;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            clients.Visibility = Visibility.Hidden;
            credits.Visibility = Visibility.Hidden;
            typesOfCredits.Visibility = Visibility.Hidden;
            switch ((((ComboBox)sender).SelectedItem as ComboBoxItem).Content)
            {
                case "Clients":
                    currentDg = clients;
                    FillGrid(sqlQuery + "Клиент", clients);
                    clients.Visibility = Visibility.Visible;    
                    break;
                case "Credits":
                    currentDg = credits;
                    FillGrid(sqlQuery + "Кредиты", credits);
                    credits.Visibility = Visibility.Visible;
                    break;
                case "Types of credits":
                    currentDg = typesOfCredits;
                    FillGrid(sqlQuery + "ВидКредита", typesOfCredits);
                    typesOfCredits.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void DeleteRow_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            DataRowView view = (DataRowView)btn.DataContext;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = string.Format("delete from {0} where {1} = {2};", currentDg.Tag, currentDg.Columns[0].SortMemberPath, view.Row.ItemArray[0]);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
            
            view.Row.Delete();      
        }

        private void SaveRow_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sqlQuery + currentDg.Tag, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                switch(currentDg.Tag.ToString())
                {
                    case "Клиент":
                        adapter.InsertCommand = new SqlCommand("sp_InsertClient", connection);
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 30, "Название_фирмы"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@own", SqlDbType.NVarChar, 30, "Вид_собственности"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 30, "Адрес"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 20, "Телефон"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@contact", SqlDbType.NVarChar, 30, "Контактное_лицо"));
                        break;
                    case "Кредиты":
                        adapter.InsertCommand = new SqlCommand("sp_InsertCredit", connection);
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@sum", SqlDbType.Money, 0, "Сумма"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@issueDate", SqlDbType.Date, 0, "Дата_выдачи"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@returnDate", SqlDbType.Date, 0, "Дата_возврата"));
                        break;
                    case "ВидКредита":
                        adapter.InsertCommand = new SqlCommand("sp_InsertTypeOfCredit", connection);
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 30, "Название"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@rate", SqlDbType.Real, 0, "Ставка"));
                        adapter.InsertCommand.Parameters.Add(new SqlParameter("@period", SqlDbType.TinyInt, 0, "Срок"));
                        break;
                }
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.Update(ds);
            }
        }

        private void AddRow_Click(object sender, RoutedEventArgs e)
        {
            if (!(currentDg is null))
            {
                while (!(ds.Tables[0].Rows.Count < this.pageSize))
                {
                    this.pageNumber++;
                    using (SqlConnection connection = new SqlConnection(this.connectionString))
                    {
                        this.adapter = new SqlDataAdapter(sqlQuery + currentDg.Tag + " ORDER BY " + ((Binding)currentDg.Columns[0].ClipboardContentBinding).Path.Path + " OFFSET((" + pageNumber + ") * " + pageSize + ") " + "ROWS FETCH NEXT " + pageSize + " ROWS ONLY", connection);
                        this.ds.Tables[0].Rows.Clear();
                        this.adapter.Fill(this.ds.Tables[0]);
                    }
                }
                currentDg.CanUserAddRows = true;
            }
        }

        private void Navigation_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                switch ((sender as Button).Name)
                {
                    case "next":
                        if (ds.Tables[0].Rows.Count < pageSize) return;
                        pageNumber++;
                        break;
                    case "back":
                        if (pageNumber == 0) return;
                        pageNumber--;
                        break;
                }
                adapter = new SqlDataAdapter(sqlQuery + currentDg.Tag + " ORDER BY " + ((Binding)currentDg.Columns[0].ClipboardContentBinding).Path.Path + " OFFSET((" + pageNumber + ") * " + pageSize + ") " + "ROWS FETCH NEXT " + pageSize + " ROWS ONLY", connection);
                ds.Tables[0].Rows.Clear();
                adapter.Fill(ds, currentDg.Name);
                FillGrid(sqlQuery + currentDg.Tag, currentDg);
            }
        }
    }
}
