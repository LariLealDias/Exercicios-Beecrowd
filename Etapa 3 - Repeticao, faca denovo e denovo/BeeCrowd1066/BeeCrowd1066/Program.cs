namespace exercicio1064
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeros;
            int qtdNumeroPar = 0;
            int par;
            int qtdNumeroImpar = 0;
            int qtdNumeroPositivo = 0;
            int qtdNumeroNegativo = 0;

            for (int i = 0; i < 5; i++)
            {
                numeros = int.Parse(Console.ReadLine());

                par = numeros % 2;

                if (par == 0)
                {
                    qtdNumeroPar++;
                }
                else if(par != 0)
                {
                    qtdNumeroImpar++;
                }
                if (numeros > 0)
                {
                    qtdNumeroPositivo++;
                }else if(numeros < 0)
                {
                    qtdNumeroNegativo++;
                }
            }
            Console.WriteLine($"{qtdNumeroPar} valor(es) par(es)");
            Console.WriteLine($"{qtdNumeroImpar} valor(es) impar(es)");
            Console.WriteLine($"{qtdNumeroPositivo} valor(es) positivo(s)");
            Console.WriteLine($"{qtdNumeroNegativo} valor(es) negativo(s)");
        }
    }
}