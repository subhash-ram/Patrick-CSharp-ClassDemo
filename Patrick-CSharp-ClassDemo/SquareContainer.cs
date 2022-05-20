using System;

namespace Patrick_CSharp_ClassDemo
{
    public class SquareContainer : Container
    {
        public override double AreaOfBase(int length)
        {
            double area = length * length;
            Console.WriteLine("Square Area = " + area);
            return area;
        }
    }
}