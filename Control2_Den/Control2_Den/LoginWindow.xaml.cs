using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public partial class LoginWindow : Window
    {
        private readonly LibraryRepository _repository;

        public LoginWindow()
        {
            InitializeComponent();
            _repository = new LibraryRepository();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            var user = _repository.Authenticate(login, password);
            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            var mainWindow = new MainWindow(_repository, user);
            mainWindow.Show();
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow(_repository);
            registerWindow.ShowDialog();
        }
    }
}