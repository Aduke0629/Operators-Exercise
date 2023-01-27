namespace OperatorExercise
{
    public class Program
    {
        

        static void Main(string[] args)
        {

            int a = 17;

            int b = 4;

            int quiotient = a / b;

            int remainder = a % b;

            if (a == 17 && b == 4) ;

            Console.WriteLine($"{a}/{b} is {quiotient} remainder {remainder}");


            Console.WriteLine("What is the radius of our circle?");

            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of your circle with the radius of {radius} is {AreaOfCircle(radius)}");

        }

        public static double AreaOfCircle(double radius)
        {
           return Math.PI * (radius * radius);

        }
        

      
        
           
     

         
        
        

        
    }
   
}
