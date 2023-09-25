namespace OperatorExercise
{
    public class Program
    {

        public static Double AreaOfCircle(double radius) 
        {
            return (Math.PI * radius * radius);
        }
        static void Main(string[] args)
        {
            // For division, create two integer variables called a and b.
            var a = 17;
            var b = 4;
            
            var quotient = a / b;
            Console.WriteLine($"The quotient of the division is {quotient}");

            var remainder = a % b;
            Console.WriteLine($"The remainder of the division is {remainder}");

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("I am creating a method that will calculate the area of a circle based on its radius. Enter a number for the radius so I can calculate the area of the circle.");
            
            int radius = Convert.ToInt32(Console.ReadLine());
            //var radius = double.Parse(Console.ReadLine());
            
            Console.WriteLine("the area of your circle is " + AreaOfCircle(radius));
            //Console.WriteLine(AreaOfCircle(radius)); 


        }
    }
}
