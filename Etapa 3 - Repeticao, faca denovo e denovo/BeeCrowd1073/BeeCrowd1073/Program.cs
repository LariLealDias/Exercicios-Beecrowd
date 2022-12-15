namespace exercicio1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            int calculo = 0;

            for(int i = 1; i <= entrada; i++)
            {
                if(i % 2 == 0)
                {
                    calculo = i * i;
                    Console.WriteLine($"{i}^2 = {calculo}");
                }
            }
         


        }
    }
}