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
using System.Text.RegularExpressions;
using IZBankingATMClassLibrary;

namespace IZBankingATM
{
    /// <summary>
    /// Interaction logic for CustomerWithdraw.xaml
    /// </summary>
    public partial class CustomerWithdraw : Window
    {
        public CustomerWithdraw()
        {
            InitializeComponent();
        }

        CustomerActions customerActions = new CustomerActions();
        private void SaldoBackButton(object sender, RoutedEventArgs e)
        {
            CustomerDashboard Dashboard = new CustomerDashboard();
            Dashboard.Show();
            this.Close();
        }

        private void Withdraw5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("5"));
        }

        private void Withdraw10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("10"));
        }

        private void Withdraw20_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("20"));
        }
        private void Withdraw50_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("50"));
        }

        private void Withdraw100_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("100"));
        }

        private void Withdraw200_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("200"));
        }

        private void Withdraw500_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw("500"));
        }

        private void WithdrawInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static readonly Regex _regex = new Regex("[^0-9,]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void WithdrawInput_DataObjectPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void Withdrawi_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(customerActions.customerWithdraw(WithdrawInput.Text));
        }
    }
}
