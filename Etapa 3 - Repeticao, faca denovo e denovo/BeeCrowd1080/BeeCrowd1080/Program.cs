namespace exercicio1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroEntrada;
            int maiorNumero = 0;
            int indice = 0;

            for(int i = 1; i <= 100; i++)
            {
                numeroEntrada = int.Parse(Console.ReadLine());

                if(numeroEntrada > maiorNumero)
                {
                    indice = i;
                    maiorNumero = numeroEntrada;
                }
            }
            Console.WriteLine(maiorNumero);
            Console.WriteLine(indice);

        }
    }
}