namespace Patrick_CSharp_ClassDemo
{
    public class Square
    {
        protected int iValue;
        public virtual int CalculateArea(int length)
        {
            return (length * length);
        }
    }
}