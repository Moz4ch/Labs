using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public partial class BookEditWindow : Window
    {
        public Book Book { get; private set; }

        public BookEditWindow()
        {
            InitializeComponent();
            Book = new Book
            {
                ArticleNumber = Guid.NewGuid().ToString("N").Substring(0, 8),
                ReleaseDate = DateTime.Today,
                Status = BookStatus.Available
            };
            DataContext = Book;
        }

        public BookEditWindow(Book book)
        {
            InitializeComponent();
            Book = new Book
            {
                ArticleNumber = book.ArticleNumber,
                Title = book.Title,
                Genre = book.Genre,
                Description = book.Description,
                ReleaseDate = book.ReleaseDate,
                Status = book.Status,
                CurrentReader = book.CurrentReader
            };
            DataContext = Book;
            ArticleTextBox.IsReadOnly = true;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Book.ArticleNumber) ||
                string.IsNullOrWhiteSpace(Book.Title))
            {
                MessageBox.Show("Заполните обязательные поля (Артикул и Название)");
                return;
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}