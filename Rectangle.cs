

namespace CalculateArea
{
    public class Rectangle : Shape
    {
        public double length { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {

            return length * Width;
        }
    }
}
