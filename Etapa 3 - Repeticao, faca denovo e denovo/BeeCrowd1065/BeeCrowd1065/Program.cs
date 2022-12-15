namespace exercicio1064
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeros;
            int qtdNumerosPares = 0;

            int par;

            for (int i = 0; i < 5; i++)
            {
                numeros = int.Parse(Console.ReadLine());

                par = numeros % 2;

                if (par == 0)
                {
                    qtdNumerosPares++;
                }

            }

            Console.WriteLine($"{qtdNumerosPares} valores pares");

        }
    }
}