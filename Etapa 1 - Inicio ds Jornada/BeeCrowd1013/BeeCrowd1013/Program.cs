namespace exercicio1013
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            string[] valores = entrada.Split();

            int A = int.Parse( valores[0] );
            int B = int.Parse( valores[1] );
            int C = int.Parse( valores[2] );

            int maiorAB = (A + B + Math.Abs (A - B) ) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;   
            
            Console.WriteLine( $"{maiorABC} eh o maior");
            
        }
    }
}