namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   //Exercise 1
            int a = 17;
            int b = 4;
            
            int quotient = a / b;
            int remainder = a % b;

            if ( a == 17 && b == 4){
                Console.WriteLine($" 17/4 {quotient} is {b} remainder is {remainder}.");
            }

            AreaOfCircle();
        }

        //Exercise2
        static void AreaOfCircle(){
            Console.WriteLine("Enter the radius of your circle. ");
            //double.Parse created a null reference
            var radius = Convert.ToDouble(Console.ReadLine());
            var formula = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Your area of the circle is {formula}.");

        }
    }
}
