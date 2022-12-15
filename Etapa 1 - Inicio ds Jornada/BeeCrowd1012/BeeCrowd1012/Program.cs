namespace exercicio1012
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string entradaValores = Console.ReadLine();
            string[] entradas = entradaValores.Split();

            double A = double.Parse(entradas[0]);
            double B = double.Parse(entradas[1]);
            double C = double.Parse(entradas[2]);

            double triangulo = (A * C) / 2;
            Console.WriteLine($"TRIANGULO: {triangulo:F3}");

            double circulo = 3.14159 * (C * C);
            Console.WriteLine($"CIRCULO: {circulo:F3}");

            double trapezio = ((A + B) * C) / 2;
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");

            double quadrado = B * B;
            Console.WriteLine($"QUADRADO: {quadrado:F3}");

            double retangulo = A * B;
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}