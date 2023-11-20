using Circle;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            CircleCalculation circleCalculation = new CircleCalculation();
            circleCalculation.radius = radius;

            Console.WriteLine("The area of circle: "+ circleCalculation.GetArea());
            Console.WriteLine("The Diameter of circle: " + circleCalculation.GetDiameter());
            Console.WriteLine("The Perimeter of circle: " + circleCalculation.GetPerimeter());

            Console.WriteLine("Do you want to calculate again? press y");
            string key = Console.ReadLine();
            
            if(key.ToUpper() != "Y") 
            {
                break;
            }
        }
    }
}