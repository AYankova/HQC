namespace TemplateMethodPattern
{
    using System;
    using TemplateMethodPattern.Exporters;

    public class Program
    {
        public static void Main()
        {
            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to Word file
            exporter = new WordExporter();
            exporter.ExportFormatedData();
        }
    }
}
