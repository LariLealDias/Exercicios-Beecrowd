namespace exercicio1115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] cordenadas;
            int x;
            int y;

            while (true)
            {
                cordenadas = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));
                x = cordenadas[0];
                y = cordenadas[1];

                if(x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if(x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }else if(y > 0 && x < 0)
                {
                    Console.WriteLine("segundo");
                }else if(x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }else if(x == y)
                {
                    break;
                }
            }

        }
    }
}