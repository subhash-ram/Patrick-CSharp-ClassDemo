namespace Patrick_CSharp_ClassDemo
{
    public class ChildSmallBox : SmallBox
    {
        public double CalculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}