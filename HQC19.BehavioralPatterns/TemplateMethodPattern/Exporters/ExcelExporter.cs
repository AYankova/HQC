namespace TemplateMethodPattern.Exporters
{
    using System;

    internal class ExcelExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to an Excel file.");
        }
    }
}
