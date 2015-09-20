namespace TemplateMethodPattern.Exporters
{
    using System;

    internal class PdfExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a PDF file.");
        }
    }
}
