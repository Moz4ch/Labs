using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class ReportGenerator
    {
        public abstract void CollectData();
        public abstract void DataProcessing();
        public abstract void FormattingData();
        public abstract void ReportExport();
        public void GenerateReport()
        {
            CollectData();
            DataProcessing();
            FormattingData();
            ReportExport();
        }
    }
}