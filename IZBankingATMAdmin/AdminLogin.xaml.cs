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
using System.Windows.Navigation;
using System.Windows.Shapes;
using IZBankingATMClassLibrary;

namespace IZBankingATMAdmin
{
    /// <summary>
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Window
    {
        AdminActions adminActions = new AdminActions();
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string employee_number = employee_numberbx.Text;
            string password = passwordbx.Password;

            if (adminActions.adminLogin(employee_number, password))
            {
                AdminDashboard Dashboard = new AdminDashboard();
                Dashboard.Show();
                this.Close();
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        private void TEMPBtnLogin_Click(object sender, RoutedEventArgs e)
        {
            CustomerBase Dashboard = new CustomerBase();
            Dashboard.Show();
            this.Close();
        }
    }
}
