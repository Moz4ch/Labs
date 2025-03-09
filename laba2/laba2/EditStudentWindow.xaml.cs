using System.Windows;

namespace UniversityManagementSystem
{
    public partial class EditStudentWindow : Window
    {
        private Student _student;

        public EditStudentWindow(Student student)
        {
            InitializeComponent();
            _student = student;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            FirstNameTextBox.Text = _student.FirstName;
            LastNameTextBox.Text = _student.LastName;
            AgeTextBox.Text = _student.Age.ToString();
            EmailTextBox.Text = _student.Email;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _student.FirstName = FirstNameTextBox.Text;
            _student.LastName = LastNameTextBox.Text;
            _student.Age = int.Parse(AgeTextBox.Text);
            _student.Email = EmailTextBox.Text;

            this.Close();
        }
    }
}