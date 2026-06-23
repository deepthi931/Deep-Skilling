using System;

namespace Exercise2_FactoryMethodPattern
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document...");
        }
    }
}