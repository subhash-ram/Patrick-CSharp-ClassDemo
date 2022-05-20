namespace Patrick_CSharp_ClassDemo
{
    public class SmallBox
    {
        private int length;
        private int width;

        public string color { private set; get; }
        

        public SmallBox()
        {
            length = 10;
            width = 20;
        }
        
        public SmallBox(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int CalculateArea()
        {
            color = "red";
            return this.length * this.width;
        }
    }
}