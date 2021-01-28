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

namespace IZBankingATM
{
    /// <summary>
    /// Interaction logic for CustomerDashboard.xaml
    /// </summary>
    public partial class CustomerDashboard : Window
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void AccountBalance_Click(object sender, RoutedEventArgs e)
        {
            AccountBalance Dashboard = new AccountBalance();
            Dashboard.Show();
            this.Close();
        }

        private void AccontTransactions_Click(object sender, RoutedEventArgs e)
        {
            CustomerTransactions Dashboard = new CustomerTransactions();
            Dashboard.Show();
            this.Close();
        }

        private void WithdrawMoney_Click(object sender, RoutedEventArgs e)
        {
            CustomerWithdraw Dashboard = new CustomerWithdraw();
            Dashboard.Show();
            this.Close();
        }

        private void DepositMoney_Click(object sender, RoutedEventArgs e)
        {
            CustomerDeposit Dashboard = new CustomerDeposit();
            Dashboard.Show();
            this.Close();
        }
    }
}
