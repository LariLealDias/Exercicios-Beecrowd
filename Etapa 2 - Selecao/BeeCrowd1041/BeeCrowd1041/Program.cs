namespace exercicio1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double x = double.Parse(entrada[0]);
            double y = double.Parse(entrada[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            } else if (x == 0) 
            {
                Console.WriteLine("Eixo Y");
            } else if(y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x < 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("Q3");
                    //y negativo
                }
                else
                {
                    Console.WriteLine("Q2");
                    //y positivo
                }
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");
                    //y positivo

                }
                else
                {
                    Console.WriteLine("Q4");
                    //y negativo
                }
            }
        }
    }
}