namespace exercicio1075
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int tabuada;

            for(int i = 1; i <= 10; i++)
            {
                tabuada = i * numero;
                Console.WriteLine($"{i} x {numero} = {tabuada}");
            }

        }
    }
}
