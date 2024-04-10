namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;

            int quotient = a / b;


            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");



            Console.WriteLine("Please enter the radius of your circle"); ;
            

            var radius = double.Parse(Console.ReadLine());

            

            Console.WriteLine(AreaOfCircle(radius));
        }

        public static double AreaOfCircle(double Radius)
        {
            var area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }
    }
}










