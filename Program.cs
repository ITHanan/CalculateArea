namespace CalculateArea
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("--------Its time to Calculat the Circle area--------\n");

            Console.WriteLine("please Enter Radius ");

            string radiusInString = Console.ReadLine()!;
            double radius = Convert.ToDouble(radiusInString);

            Shape mycircle = new Circle { Radius = radius };//polymorfism Circle behandlsa som shape
            mycircle.CalculateArea();
            Console.WriteLine("The Area of the Cirvle is :" + mycircle.CalculateArea()+"\n\n");


            Console.WriteLine("--------Now its time to Calculat the Rectangle area--------\n");


            Console.WriteLine(" please Enter the length of the Rectangle:\n ");

            string lengthOfTheRectangleSomString = Console.ReadLine()!;
            double lengthOfTheRectangle = Convert.ToDouble(lengthOfTheRectangleSomString);

            Console.WriteLine("please Enter the width of the Rectangle:\n ");

            string widthOfTheRectangleSomString = Console.ReadLine()!;
            double widthOfTheRectangle = Convert.ToDouble(widthOfTheRectangleSomString);


            Shape myRectangle = new Rectangle { length = lengthOfTheRectangle, Width = widthOfTheRectangle };//polymorfism Rectangle behandlsa som shape

            Console.WriteLine("The Area of the Rectangle is : " + myRectangle.CalculateArea()+"\n\n");


            Console.WriteLine("--------Now its time to Calculat the Square area--------\n");
           


            Console.WriteLine("please Enter the Side of the Square: ");

            String SideOfTheSquareSomString = Console.ReadLine()!;
            double SideOfTheSquare = Convert.ToDouble(SideOfTheSquareSomString);

            Shape mySquare = new Square { Side = SideOfTheSquare };//polymorfism Square behandlsa som shape
            Console.WriteLine("The area of a Square is: " + mySquare.CalculateArea() + "\n\n");





            








        }
    }
}
