using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excel = excelFactory.CreateDocument();
            excel.Open();

            Console.WriteLine();
            Console.WriteLine("Factory Method Pattern Implemented Successfully.");
        }
    }
}