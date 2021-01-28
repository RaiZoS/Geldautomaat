using System;
using System.Data;
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
using IZBankingATMClassLibrary;

namespace IZBankingATMAdmin
{
    /// <summary>
    /// Interaction logic for CustomerBase.xaml
    /// </summary>
    public partial class CustomerBase : Window
    {
        AdminActions adminActions = new AdminActions();
        public CustomerBase()
        {
            InitializeComponent();

            List<User> users = new List<User>();

            refreshDataGrid();
        }

        public void refreshDataGrid()
        {
            dataGrid.ItemsSource = adminActions.fillCustomerTable();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminDashboard Dashboard = new AdminDashboard();
            Dashboard.Show();
            this.Close();
        }
        
    }
    public class User
    {
        public int id { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string account_number { get; set; }

        public string edit_account { get; set; }
    }
}
