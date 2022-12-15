namespace exercicio1067
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*    int numero = int.Parse(Console.ReadLine());

                bool impar = numero % 2 != 0;

                for(int i = 1; i <= numero; i++)
                {
                    if (impar)
                    {
                        Console.WriteLine(i);
                    }
                }*/

            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            


        }
    }
}