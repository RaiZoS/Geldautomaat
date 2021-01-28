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
    /// Interaction logic for AccountBalance.xaml
    /// </summary>
    public partial class AccountBalance : Window
    {
        CustomerActions customerActions = new CustomerActions();
        public AccountBalance()
        {
            InitializeComponent();
        }

        private void SaldoBackButton(object sender, RoutedEventArgs e)
        {
            CustomerDashboard Dashboard = new CustomerDashboard();
            Dashboard.Show();
            this.Close();
        }

        private void TextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            CustomerBalanceOutput.Text = "€" + customerActions.accountBalance();
        }
    }
}
