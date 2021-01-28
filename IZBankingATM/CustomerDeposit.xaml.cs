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
    /// Interaction logic for CustomerDeposit.xaml
    /// </summary>
    public partial class CustomerDeposit : Window
    {
        CustomerActions customerActions = new CustomerActions();
        public CustomerDeposit()
        {
            InitializeComponent();
        }

        private void SaldoBackButton(object sender, RoutedEventArgs e)
        {
            CustomerDashboard Dashboard = new CustomerDashboard();
            Dashboard.Show();
            this.Close();
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            if (customerActions.deposit(DepositInput.Text))
            {
                CustomerDashboard Dashboard = new CustomerDashboard();
                Dashboard.Show();
                this.Close();
            }
        }

        private void DepositInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static readonly Regex _regex = new Regex("[^0-9,]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void DepositInput_DataObjectPasting(object sender, DataObjectPastingEventArgs e)
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
    }
}
