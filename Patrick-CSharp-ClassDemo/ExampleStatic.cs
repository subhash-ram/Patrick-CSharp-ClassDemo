using System;

namespace Patrick_CSharp_ClassDemo
{
    public class ExampleStatic
    {
        public static int staticCount;
        public int nonStaticCount;

        public void CalculateStaticCount()
        {
            Console.WriteLine("static count:" + staticCount);
            staticCount++;
        }

        public void CalculateNonStaticCount()
        {
            Console.WriteLine("non-static count: "+ nonStaticCount);
            nonStaticCount++;
        }

        //static constructor is fired before instance constructor. used to set class vales.
        static ExampleStatic()
        {
            Console.WriteLine("Static Constructor");
        }
        
        public ExampleStatic()
        {
            Console.WriteLine("Non-static constructor");
        }
    }
}