namespace exercicio1009
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            double comissao = (totalVendas * 15) / 100;

            double resultado = salarioFixo + comissao;

            Console.WriteLine($"TOTAL = R$ {resultado:F2}");


        }
    }
}