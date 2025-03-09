using System.Collections.Generic;

public class Course
{
    public string Name { get; set; }
    public string Instructor { get; set; } 
    public string Schedule { get; set; } 
    public int MaxStudents { get; set; } 
    public List<Student> Students { get; set; } = new List<Student>(); 
}