using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace UniversityManagementSystem
{
    public static class CourseRepository
    {
        public static List<Course> Courses { get; } = new List<Course>();

        public static void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public static void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }

        public static Course FindCourseByName(string name)
        {
            return Courses.FirstOrDefault(c => c.Name == name);
        }

        public static List<Course> GetAllCourses()
        {
            return Courses;
        }

        public static void AddStudentToCourse(string courseName, Student student)
        {
            var course = FindCourseByName(courseName);
            if (course != null && course.Students.Count < course.MaxStudents)
            {
                course.Students.Add(student);
            }
            else
            {
                MessageBox.Show("Курс полон или не найден");
            }
        }

        public static void RemoveStudentFromCourse(string courseName, Student student)
        {
            var course = FindCourseByName(courseName);
            if (course != null)
            {
                course.Students.Remove(student);
            }
        }
        public static void InitializeTestData()
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