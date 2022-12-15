using System.Collections.Immutable;

namespace exercicio1042
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(entrada[0]);
            int valor2 = int.Parse(entrada[1]);
            int valor3 = int.Parse(entrada[2]);

            int[] valores = new int[] { valor1, valor2, valor3 };

            Array.Sort(valores);

            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            Console.WriteLine();
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);


        }
    }
}