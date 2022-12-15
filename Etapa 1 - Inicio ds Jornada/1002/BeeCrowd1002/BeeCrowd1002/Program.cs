using System.Globalization;

namespace exercicio1002
{
    public class program
    {
        public static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = Double.Parse( Console.ReadLine() );
            double area =  n * Math.Pow(raio,2);       

            Console.WriteLine($"A={area:F4}");

        }
    }
}
