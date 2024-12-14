using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class CourseReportGenerator : ReportGenerator
    {
        public override void CollectData()
        {
            Console.WriteLine("Курсы: Сбор информации");
        }

        public override void DataProcessing()
        {
            Console.WriteLine("Курсы: Обработка информации");
        }

        public override void FormattingData()
        {
            Console.WriteLine("Курсы: Форматирование информации");
        }

        public override void ReportExport()
        {
            Console.WriteLine("Курсы: Экспорт отчета");
        }
    }
}
