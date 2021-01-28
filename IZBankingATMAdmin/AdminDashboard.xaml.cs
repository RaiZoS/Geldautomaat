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

namespace IZBankingATMAdmin
{
    /// <summary>
    /// Interaction logic for AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : Window
    {
        public AdminDashboard()
        {
            InitializeComponent();
            WelcomeTexts();
        }

        public void WelcomeTexts()
        {
            WelcomeText.Text = "Welkom " + AdminInfo.AdminName;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NewCustomerButtonClick(object sender, RoutedEventArgs e)
        {
            AddCustomer Dashboard = new AddCustomer();
            Dashboard.Show();
            this.Close();
        }

        private void CustomerBaseButtonClick(object sender, RoutedEventArgs e)
        {
            CustomerBase Dashboard = new CustomerBase();
            Dashboard.Show();
            this.Close();
        }
    }
}
