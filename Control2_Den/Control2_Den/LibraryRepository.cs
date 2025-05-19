using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public class LibraryRepository
    {
        private List<User> _users;
        private List<Book> _books;

        public LibraryRepository()
        {
            _users = new List<User>();
            _books = new List<Book>();

            _users.Add(new User
            {
                Login = "admin",
                Password = "admin",
                FullName = "Администратор",
                PhoneNumber = "+79001234567",
                RegistrationDate = DateTime.Now
            });

            _books.Add(new Book
            {
                ArticleNumber = "0001",
                Title = "Война и мир",
                Genre = "Роман",
                Description = "Классика русской литературы",
                ReleaseDate = new DateTime(1869, 1, 1),
                Status = BookStatus.Available
            });
        }

        public User Authenticate(string login, string password)
        {
            return _users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

        public bool Register(User newUser)
        {
            if (_users.Any(u => u.Login == newUser.Login))
                return false;

            newUser.RegistrationDate = DateTime.Now;
            _users.Add(newUser);
            return true;
        }

        public List<Book> GetAllBooks() => _books;

        public void AddBook(Book book) => _books.Add(book);

        public void UpdateBook(Book book)
        {
            var existing = _books.FirstOrDefault(b => b.ArticleNumber == book.ArticleNumber);
            if (existing != null)
            {
                existing.Title = book.Title;
                existing.Genre = book.Genre;
                existing.Description = book.Description;
                existing.ReleaseDate = book.ReleaseDate;
                existing.Status = book.Status;
                existing.CurrentReader = book.CurrentReader;
            }
        }

        public void DeleteBook(string articleNumber)
        {
            var book = _books.FirstOrDefault(b => b.ArticleNumber == articleNumber);
            if (book != null)
                _books.Remove(book);
        }

        public bool IssueBook(string articleNumber, User user)
        {
            var book = _books.FirstOrDefault(b => b.ArticleNumber == articleNumber);
            if (book == null || book.Status != BookStatus.Available)
                return false;

            book.Status = BookStatus.Issued;
            book.CurrentReader = user;
            return true;
        }

        public bool ReturnBook(string articleNumber)
        {
            var book = _books.FirstOrDefault(b => b.ArticleNumber == articleNumber);
            if (book == null || book.Status != BookStatus.Issued)
                return false;

            book.Status = BookStatus.Available;
            book.CurrentReader = null;
            return true;
        }

        public bool SendToMaintenance(string articleNumber)
        {
            var book = _books.FirstOrDefault(b => b.ArticleNumber == articleNumber);
            if (book == null || book.Status != BookStatus.Available)
                return false;

            book.Status = BookStatus.UnderMaintenance;
            return true;
        }
    }
}
