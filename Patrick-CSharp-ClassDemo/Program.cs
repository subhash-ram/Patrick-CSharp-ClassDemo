using System;

namespace Patrick_CSharp_ClassDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // SmallBox ups = new SmallBox(100, 200);
            // Console.WriteLine("UPS Box Area:" + ups.CalculateArea());
            // Console.WriteLine(ups.color);
            //
            // SmallBox fedex = new SmallBox(300, 500);
            // Console.WriteLine("FedEx Box Area:" + fedex.CalculateArea());
            //
            // SmallBox fedex2 = new SmallBox();
            // Console.WriteLine("FedEx Area (Default Costructor): " + fedex2.CalculateArea());
            //
            //
            // ChildSmallBox objChildBox = new ChildSmallBox();
            // Console.WriteLine("volume: " + objChildBox.CalculateVolume(12, 12, 12));

            // Employee alex = new Employee();
            // alex.CalculateTax(20000);
            // alex.VacationDays(9);
            //
            // PartTimeEmployee lynda = new PartTimeEmployee();
            // lynda.CalculateTax(20000);
            // lynda.VacationDays(9);

            // Container c = new SquareContainer(); //Superclass object = new Subclass(); --> Sub class can be instantiated this way also.
            // c.CalculateVolume(10,5);
            //
            // c = new CircleContainer();
            // c.CalculateVolume(10,5);

            // Cube c = new Cube();
            // Console.WriteLine(c.CalculateArea(5));

            ExampleStatic obj1 = new ExampleStatic();
            ExampleStatic obj2 = new ExampleStatic();

            ExampleStatic.staticCount = 1; //static variables is one per class and one per object. uses of static: keeping website visit counter.
            obj1.nonStaticCount = 1;
            obj2.nonStaticCount = 1;

            obj1.CalculateStaticCount();
            obj2.CalculateStaticCount();
            obj2.CalculateStaticCount();
            
            obj1.CalculateNonStaticCount();
            obj2.CalculateNonStaticCount();
            obj2.CalculateNonStaticCount();
        }
    }
}