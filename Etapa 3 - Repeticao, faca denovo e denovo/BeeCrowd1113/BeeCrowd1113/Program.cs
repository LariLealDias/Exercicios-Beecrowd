namespace exercicio113
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] duplaDeValores;
            int maior;
            int menor;

            while (true)
            {
                duplaDeValores = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (duplaDeValores[0] > duplaDeValores[1])
                {
                    Console.WriteLine("Decrescente");
                }
                else if(duplaDeValores[0] == duplaDeValores[1])
                {
                    break;
                }else
                {
                    Console.WriteLine("Crescente");
                }
            }

        }
    }
}