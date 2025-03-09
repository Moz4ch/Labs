using System.Windows;

namespace UniversityManagementSystem
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(AgeTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                MessageBox.Show("Укажите действующий возраст");
                return;
            }

            var student = new Student
            {
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = age,
                Email = EmailTextBox.Text
            };

            StudentRepository.Students.Add(student);
            this.Close();
        }
    }
}