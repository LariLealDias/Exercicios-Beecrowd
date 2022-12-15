namespace exercicio1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
             int qtdTestes = int.Parse(Console.ReadLine());

            int intervalo1 = 10;
            int intervalo2 = 20;

            int valor;

            int dentro = 0;
            int fora = 0;

           for(int i = 0; i < qtdTestes; i++)
            {
                valor = int.Parse(Console.ReadLine());

                if (valor >= intervalo1 && valor <= intervalo2)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
                
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");


   


        }
    }
}