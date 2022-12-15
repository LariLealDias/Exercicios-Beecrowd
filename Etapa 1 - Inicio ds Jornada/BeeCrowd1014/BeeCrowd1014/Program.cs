namespace exercicio1014
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int distanciaTotalKm = int.Parse(Console.ReadLine());
            double totalCombustivelGasto = double.Parse(Console.ReadLine());

            double calculo = distanciaTotalKm / totalCombustivelGasto;

            Console.WriteLine($"{calculo:F3} km/l");
        }
    }
}