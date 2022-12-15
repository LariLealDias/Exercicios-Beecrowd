namespace exercicio1015
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string entrada1 = Console.ReadLine();
            string[] valores1 = entrada1.Split();
            double x1 = double.Parse(valores1[0]);
            double y1 = double.Parse(valores1[1]);

            string entrada2 = Console.ReadLine();
            string[] valores2 = entrada2.Split();
            double x2 = double.Parse(valores2[0]);
            double y2 = double.Parse(valores2[1]);

            double primeiroCalculo = Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2);
            double distancia = Math.Sqrt(primeiroCalculo);

            Console.WriteLine($"{distancia:F4}");

        }
    }
}