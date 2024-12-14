using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class StudentReportGenerator : ReportGenerator
    {
        public override void CollectData()
        {
            Console.WriteLine("Студенты: Сбор информации");
        }

        public override void DataProcessing()
        {
            Console.WriteLine("Студенты: Обработка информации");
        }

        public override void FormattingData()
        {
            Console.WriteLine("Студенты: Форматирование информации");
        }

        public override void ReportExport()
        {
            Console.WriteLine("Студенты: Экспорт отчета");
        }
    }
}
