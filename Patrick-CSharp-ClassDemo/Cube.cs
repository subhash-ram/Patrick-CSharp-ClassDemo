namespace Patrick_CSharp_ClassDemo
{
    public class Cube : Square
    {
        public override int CalculateArea(int length)
        {
            return base.CalculateArea(length) * 6;
            
        }
    }
}