namespace exercicio1064
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double numeros;
            int qtdNumerosPositivos = 0;
            double soma = 0;
            

            for (int i = 0; i < 6; i++)
            {
                numeros = double.Parse(Console.ReadLine());

                if (numeros > 0)
                {
                    qtdNumerosPositivos++;
                    soma += numeros; 
                }

            }
            soma = soma / qtdNumerosPositivos;

            Console.WriteLine($"{qtdNumerosPositivos} valores positivos\n{soma:f1}");

        }
    }
}