namespace OperatorExercise
{
    public class Program
    {

        static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"{a}+{b} is {result}.");
        }

        static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"{a}-{b} is {result}.");
        }

        static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"{a}*{b} is {result}.");
        }

        static void Division(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient}. The remainder is {remainder}");
        }

        static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI* Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle, with the radius of {radius}, is {areaOfCircle}.");
        }



        static void Main(string[] args)
        {
            Addition(1, 3);

            Subtraction(10, 5);

            Multiplication(9, 5);

            Division(20, 5);

            AreaOfCircle();

        }
    }
}
