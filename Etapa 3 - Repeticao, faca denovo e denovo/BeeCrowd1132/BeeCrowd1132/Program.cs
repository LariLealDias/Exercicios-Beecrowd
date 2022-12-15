namespace exercicio1132
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;

            if(x > y)
            {
                for(int i = y; i <= x; i++)
                {
                    if(i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int i = x; i <= y; i++)
                {
                    if (i % 13 != 0)
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}