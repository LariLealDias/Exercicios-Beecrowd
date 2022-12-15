namespace exercicio1044
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int valorA = int.Parse(entrada[0]);
            int valorB = int.Parse(entrada[1]);

            bool multiplo = (valorA % valorB == 0 || valorB % valorA == 0);

            if (multiplo)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}