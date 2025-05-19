using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public partial class RegisterWindow : Window
    {
        private readonly LibraryRepository _repository;

        public RegisterWindow(LibraryRepository repository)
        {
            InitializeComponent();
            _repository = repository;
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordBox.Password,
                FullName = FullNameTextBox.Text,
                PhoneNumber = PhoneTextBox.Text
            };

            if (string.IsNullOrWhiteSpace(newUser.Login) ||
                string.IsNullOrWhiteSpace(newUser.Password) ||
                string.IsNullOrWhiteSpace(newUser.FullName))
            {
                MessageBox.Show("Заполните все обязательные поля");
                return;
            }

            if (_repository.Register(newUser))
            {
                MessageBox.Show("Регистрация успешна");
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
        }
    }
}
