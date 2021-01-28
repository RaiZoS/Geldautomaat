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
using IZBankingATMClassLibrary;

namespace IZBankingATM
{
    /// <summary>
    /// Interaction logic for CustomerTransactions.xaml
    /// </summary>
    public partial class CustomerTransactions : Window
    {
        CustomerActions customerActions = new CustomerActions();
        public CustomerTransactions()
        {
            InitializeComponent();

            customerActions.transactionHistory();

            Transaction1.Text = CustomerInfo.CustomerTransactions1;
            Transaction2.Text = CustomerInfo.CustomerTransactions2;
            Transaction3.Text = CustomerInfo.CustomerTransactions3;
        }

        private void SaldoBackButton(object sender, RoutedEventArgs e)
        {
            CustomerDashboard Dashboard = new CustomerDashboard();
            Dashboard.Show();
            this.Close();
        }
    }
}
