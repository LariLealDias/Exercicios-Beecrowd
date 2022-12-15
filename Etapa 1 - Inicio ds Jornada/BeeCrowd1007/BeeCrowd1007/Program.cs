namespace exercicio1007
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            double D = double.Parse(Console.ReadLine());

            double DIFERENCA = (A * B - C * D);

            Console.WriteLine($"DIFERENCA = {DIFERENCA}");
        }

    }
}