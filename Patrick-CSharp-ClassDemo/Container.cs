using System;

namespace Patrick_CSharp_ClassDemo
{
    //abstract classes are classes that has fully defined methods and empty methods (abstract methods)
    public abstract class Container
    {
        public void CalculateVolume(int height, int length)
        {
            double volume = AreaOfBase(length) * height;
            Console.WriteLine("Volume = " + volume);
        }

        public abstract double AreaOfBase(int length);
    }
}