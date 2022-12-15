namespace exercicio1017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double tempoGasto = double.Parse(Console.ReadLine());
            double velocidadeKm = double.Parse(Console.ReadLine());

            double calculo = (velocidadeKm * tempoGasto) / 12;

            Console.WriteLine($"{calculo:F3}");
        }
    }
}