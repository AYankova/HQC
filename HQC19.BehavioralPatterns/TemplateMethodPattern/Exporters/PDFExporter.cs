namespace TemplateMethodPattern.Exporters
{
    using System;

    internal class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}
