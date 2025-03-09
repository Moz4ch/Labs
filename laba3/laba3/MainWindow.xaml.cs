using System.Windows;

namespace UniversityManagementSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            StudentsListView.ItemsSource = null; 
            StudentsListView.ItemsSource = StudentRepository.Students;
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var addStudentWindow = new AddStudentWindow();
            addStudentWindow.ShowDialog();
            LoadStudents();
        }

        private void EditStudentButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = StudentsListView.SelectedItem as Student;
            if (selectedStudent != null)
            {
                var editStudentWindow = new EditStudentWindow(selectedStudent);
                editStudentWindow.ShowDialog();
                LoadStudents();
            }
            else
            {
                MessageBox.Show("Выберите студента для редактирования");
            }
        }
        private void ViewApplicationsButton_Click(object sender, RoutedEventArgs e)
        {
            var applicationsWindow = new ApplicationsWindow();
            applicationsWindow.ShowDialog();
        }

        private void AssignResponsibleButton_Click(object sender, RoutedEventArgs e)
        {
            var assignResponsibleWindow = new AssignResponsibleWindow();
            assignResponsibleWindow.ShowDialog();
        }
    }
}