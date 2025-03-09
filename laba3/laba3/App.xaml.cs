using System;
using System.Windows;

namespace UniversityManagementSystem
{
    public partial class App
    {
        [STAThread]
        public static void Main()
        {
            var app = new App();
            app.InitializeComponent();
            app.Run();
        }
    }
}