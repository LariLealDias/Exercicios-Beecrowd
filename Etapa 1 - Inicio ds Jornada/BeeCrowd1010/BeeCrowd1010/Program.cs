namespace exercicio1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //int tamanhoMaximo = 3;
           // string separador = " ";

            string infoProduto1 = Console.ReadLine();
            string[] resultado1 = infoProduto1.Split();
            double resultadoSoma1 = double.Parse(resultado1[1]) * double.Parse(resultado1[2]);

            string infoProduto2 = Console.ReadLine();
            string[] resultado2 = infoProduto2.Split();
            double resultadoSoma2 = double.Parse(resultado2[1]) * double.Parse(resultado2[2]);

            double total = resultadoSoma1 + resultadoSoma2;
            Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
        }
    }
}