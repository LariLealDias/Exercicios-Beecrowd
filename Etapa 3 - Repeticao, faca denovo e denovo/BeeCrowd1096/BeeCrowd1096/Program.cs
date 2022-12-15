namespace exercicio1096
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int I = 1;

            while(I <= 9)
            {
                for (int J = 7; J > 4; J--)
                {
                    Console.WriteLine($"I={I} J={J}");
                }
                    I += 2;
                        //tem que ser 2 pois o I já começou com 1 
            }




        }
    }
}
