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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        AdminActions adminActions = new AdminActions();
        public AddCustomer()
        {
            InitializeComponent();
            
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

        private void AccountSave(object sender, RoutedEventArgs e)
        {
            string email = Email.Text;
            string sex = Sex.Text;
            string firstname = FirstName.Text;
            string lastname = LastName.Text;
            string bsn_number = CitizenServiceNumber.Text;
            string date_of_birth = DateOfBirthPicker.Text;
            string address = Address.Text;
            string house_number = HouseNumber.Text;
            string postalcode = PostalCode.Text;
            string town = Town.Text;


            

            if (adminActions.createUser(email, sex, firstname, lastname, bsn_number, date_of_birth, address, house_number, postalcode, town))
            {
                AdminDashboard Dashboard = new AdminDashboard();
                Dashboard.Show();
                this.Close();

                Popup popDashboard = new Popup();
                popDashboard.Show();
            }
        }

        private void DatePickerOpened(object sender, RoutedEventArgs e)
        {
            DateOfBirthPicker.Foreground = Brushes.Gray;
        }

        private void DatePickerClosed(object sender, RoutedEventArgs e)
        {
            DateOfBirthPicker.Foreground = Brushes.White;
        }
    }
}
