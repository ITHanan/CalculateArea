

namespace CalculateArea
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }

    }
}
