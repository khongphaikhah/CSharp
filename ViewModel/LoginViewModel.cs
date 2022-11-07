ousing DBDataContext;
using Project.Data.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Project.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        private string _username;
        private string _password;
        private bool _isErrorVisible = false;

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<object>(CanExecuteLoginCommand, ExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            return true;
        }

        private void ExecuteLoginCommand(object obj)
        {
            DataDao.init(new SqlServerDataDao());
            UserDao userDao = DataDao.Instance().GetUserDao();
            User user = userDao.find(Username, Password);
            if (user != null)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                IsErrorVisible = true;
                MessageBox.Show("Login failed");
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public bool IsErrorVisible
        {
            get => _isErrorVisible;
            set
            {
                _isErrorVisible = value;
                OnPropertyChanged(nameof(IsErrorVisible));
            }
        }
    }
}
