namespace exercicio1075
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());


            for(int i = 1; i <= 10000; i++)
            {
                if(i % numero == 2)
                {
                 
                    Console.WriteLine(i);
                }
            }
        
        }
    }
}
