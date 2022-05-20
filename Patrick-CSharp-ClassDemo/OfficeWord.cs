using System;

namespace Patrick_CSharp_ClassDemo
{
    public class OfficeWord : IOffice
    {
        public void New()
        {
            Console.WriteLine("New Word file created");
        }

        public void Print()
        {
            Console.WriteLine("Word file printed");
        }

        public void Save()
        {
            Console.WriteLine("Word file saved");
        }
    }
}