namespace exercicio1006
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double A = 2; 
            double B = 3; 
            double C = 5;

            double nota1 = A * double.Parse(Console.ReadLine());
            double nota2 = B * double.Parse(Console.ReadLine());
            double nota3 = C * double.Parse(Console.ReadLine());

            double resultadoNota = nota1 + nota2 +  nota3;
            double resultadoPeso = A + B + C;

            double media = resultadoNota / resultadoPeso;

            Console.WriteLine($"MEDIA = {media:F1}");

        }
    }
}