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
    /// Interaction logic for ATMLogin.xaml
    /// </summary>
    public partial class ATMLogin : Window
    {
        CustomerActions customerActions = new CustomerActions();
        public ATMLogin()
        {
            InitializeComponent();
        }

        private void ATMCustomerLoginBtn(object sender, RoutedEventArgs e)
        {
            string account_number = account_numberInput.Text;
            string pincode = pincodeInput.Password;

            if (customerActions.customerLogin(account_number, pincode))
            {
                CustomerDashboard Dashboard = new CustomerDashboard();
                Dashboard.Show();
                this.Close();
            }else
            {
                MessageBox.Show("Uw account is geblokeerd");
            }
        }

        private void ATMCustomerCancelBtn(object sender, RoutedEventArgs e)
        {
            account_numberInput.Text = "";
            pincodeInput.Password = "";
        }
    }
}
