namespace exercicio1011
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double resultadoRaio = Math.Pow(raio, 3);

            double volume = (4/3.0) * pi * resultadoRaio;

            Console.WriteLine($"VOLUME = {volume:F3}");
        }
    }
}