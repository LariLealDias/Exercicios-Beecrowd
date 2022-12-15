namespace exercicio1043
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double valor1 = double.Parse(entrada[0]);
            double valor2 = double.Parse(entrada[1]);
            double valor3 = double.Parse(entrada[2]);

            if ((valor1 + valor2 > valor3) && (valor2 + valor3 > valor1) && (valor1 + valor3 > valor2))
            {
                double perimetro = valor1 + valor2 + valor3;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }else
            {
                double areaTrapezio = ((valor1 + valor2) * valor3) / 2;
                Console.WriteLine($"Area = {areaTrapezio:F1}");
            }
        }
    }
}