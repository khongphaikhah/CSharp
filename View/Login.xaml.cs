using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string _username;
        private string _password;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Username { get { return _username; } set { 
                _username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Username"));
            } 
        }
        public string Password { get { return _password; } set { _password = value; } }

         public Login()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void txtUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            username.Focus();
        }
        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            password.Focus();
        }
        private void username_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(username.Text) && username.Text.Length > 0)
                username.Visibility = Visibility.Collapsed;
            else
                username.Visibility = Visibility.Visible;
        }
        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(password.Password) && password.Password.Length > 0)
                password.Visibility = Visibility.Collapsed;
            else
                password.Visibility = Visibility.Visible;
        }

        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
