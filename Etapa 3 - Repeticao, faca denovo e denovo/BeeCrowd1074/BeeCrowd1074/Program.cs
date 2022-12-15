namespace exercicio1074
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int qtdNumeros = int.Parse(Console.ReadLine());

            int numeros;

            for(int i = 0; i < qtdNumeros; i++)
            {
                numeros = int.Parse(Console.ReadLine());

                if(numeros % 2 == 0)
                {
                    if(numeros < 0)
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }else if(numeros == 0)
                    {
                        Console.WriteLine("NULL");
                    }
                    else
                    {
                        Console.WriteLine("EVEN POSITIVE");

                    }
                }
                else
                {
                    if (numeros > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");

                    }
                }
            }
        }
    }
}