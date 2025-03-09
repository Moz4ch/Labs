using System.Collections.Generic;
using System.Linq;


public class DepartmentStatistics
{
    public int TotalCourses { get; set; }
    public int TotalStudents { get; set; } 
    public Dictionary<string, int> InstructorWorkload { get; set; }
    public Dictionary<string, int> CourseFillRate { get; set; }

    public static DepartmentStatistics CalculateStatistics(List<Course> courses)
    {
        var statistics = new DepartmentStatistics
        {
            TotalCourses = courses.Count,
            TotalStudents = courses.Sum(c => c.Students.Count),
            InstructorWorkload = new Dictionary<string, int>(),
            CourseFillRate = new Dictionary<string, int>()
        };

        foreach (var course in courses)
        {
            if (statistics.InstructorWorkload.ContainsKey(course.Instructor))
            {
                statistics.InstructorWorkload[course.Instructor] += 1;
            }
            else
            {
                statistics.InstructorWorkload[course.Instructor] = 1;
            }
        }

        foreach (var course in courses)
        {
            double fillRate = (double)course.Students.Count / course.MaxStudents * 100;
            statistics.CourseFillRate[course.Name] = (int)fillRate;
        }

        return statistics;
    }
}
