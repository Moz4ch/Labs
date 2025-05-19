using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public partial class MainWindow : Window
    {
        private readonly LibraryRepository _repository;
        private readonly User _currentUser;

        public MainWindow(LibraryRepository repository, User currentUser)
        {
            InitializeComponent();
            _repository = repository;
            _currentUser = currentUser;

            CurrentUserTextBlock.Text = $"{currentUser.FullName} ({currentUser.Login})";
            RefreshBooksList();
        }

        private void RefreshBooksList()
        {
            BooksDataGrid.ItemsSource = null;
            BooksDataGrid.ItemsSource = _repository.GetAllBooks();
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            var addBookWindow = new BookEditWindow();
            if (addBookWindow.ShowDialog() == true)
            {
                _repository.AddBook(addBookWindow.Book);
                RefreshBooksList();
            }
        }

        private void IssueBook_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)((Button)sender).DataContext;
            if (_repository.IssueBook(book.ArticleNumber, _currentUser))
                RefreshBooksList();
            else
                MessageBox.Show("Не удалось выдать книгу");
        }

        private void ReturnBook_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)((Button)sender).DataContext;
            if (_repository.ReturnBook(book.ArticleNumber))
                RefreshBooksList();
            else
                MessageBox.Show("Не удалось вернуть книгу");
        }

        private void MaintenanceBook_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)((Button)sender).DataContext;
            if (_repository.SendToMaintenance(book.ArticleNumber))
                RefreshBooksList();
            else
                MessageBox.Show("Не удалось отправить книгу на обслуживание");
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)((Button)sender).DataContext;
            var editWindow = new BookEditWindow(book);
            if (editWindow.ShowDialog() == true)
            {
                _repository.UpdateBook(editWindow.Book);
                RefreshBooksList();
            }
        }

        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)((Button)sender).DataContext;
            if (MessageBox.Show($"Удалить книгу '{book.Title}'?", "Подтверждение",
                MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                _repository.DeleteBook(book.ArticleNumber);
                RefreshBooksList();
            }
        }
    }
}