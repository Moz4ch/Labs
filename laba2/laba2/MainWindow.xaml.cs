using System.Collections.Generic;
using System.Windows;

namespace UniversityManagementSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeTestData();
            LoadCourses();
        }

        private void LoadCourses()
        {
            CoursesListView.ItemsSource = CourseRepository.GetAllCourses();
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
        private void ViewStatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            var courses = CourseRepository.Courses;
            var statisticsWindow = new StatisticsWindow(courses);
            statisticsWindow.ShowDialog();
        }
        private void InitializeTestData()
        {
            var course1 = new Course
            {
                Name = "Mathematics",
                Instructor = "John Doe",
                Schedule = "Mon 10:00",
                MaxStudents = 30,
                Students = new List<Student>
                {
                    new Student { FirstName = "Alice", LastName = "Smith", Age = 20, Email = "alice@example.com" },
                    new Student { FirstName = "Bob", LastName = "Johnson", Age = 22, Email = "bob@example.com" }
                }
            };

            var course2 = new Course
            {
                Name = "Physics",
                Instructor = "Jane Smith",
                Schedule = "Tue 14:00",
                MaxStudents = 25,
                Students = new List<Student>
                {
                    new Student { FirstName = "Charlie", LastName = "Brown", Age = 21, Email = "charlie@example.com" }
                }
            };

            CourseRepository.AddCourse(course1);
            CourseRepository.AddCourse(course2);
        }


    }

}