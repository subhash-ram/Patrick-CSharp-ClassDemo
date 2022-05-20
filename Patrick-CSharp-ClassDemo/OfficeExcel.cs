using System;

namespace Patrick_CSharp_ClassDemo
{
    public class OfficeExcel : IOffice
    {
        public void New()
        {
            Console.WriteLine("New Excel file created");
        }

        public void Print()
        {
            Console.WriteLine("Excel file printed");
        }

        public void Save()
        {
            Console.WriteLine("Excel file saved");
        }
    }
}