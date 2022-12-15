namespace exercicio1004
{
    public class program
    {
        public static void Main(String[] args) 
        {
            int valor1 = int.Parse( Console.ReadLine() );
            int valor2 = int.Parse( Console.ReadLine() );
            int PROD = valor1 * valor2;

            Console.WriteLine($"PROD = {PROD}");
        }
    }
}