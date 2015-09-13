namespace TemplateMethodPattern.Exporters
{
    using System;

    internal class WordExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exporting the data to a Word file.");
        }
    }
}
