using TemplateMethodPattern;

class Program
{
    static void Main(string[] args)
    {
        ReportGenerator studentReport = new StudentReportGenerator();
        studentReport.GenerateReport();

        Console.WriteLine("\n");
        ReportGenerator courseReport = new CourseReportGenerator();
        courseReport.GenerateReport();
    }
}