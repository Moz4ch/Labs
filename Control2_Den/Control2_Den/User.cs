using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
namespace LibrarySystem
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
