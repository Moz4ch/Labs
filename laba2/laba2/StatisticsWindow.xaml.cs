using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace UniversityManagementSystem
{
    public partial class StatisticsWindow : Window
    {
        public StatisticsWindow(List<Course> courses)
        {
            InitializeComponent();
            LoadStatistics(courses);
        }

        private void LoadStatistics(List<Course> courses)
        {
            var statistics = DepartmentStatistics.CalculateStatistics(courses);

            TotalCoursesTextBlock.Text = statistics.TotalCourses.ToString();
            TotalStudentsTextBlock.Text = statistics.TotalStudents.ToString();

            InstructorWorkloadListView.ItemsSource = statistics.InstructorWorkload.ToList();

            CourseFillRateListView.ItemsSource = statistics.CourseFillRate.ToList();
        }
    }
}