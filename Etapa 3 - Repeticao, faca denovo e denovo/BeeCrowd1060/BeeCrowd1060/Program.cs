namespace exercicio1060
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            double numeros;
            int qtdNumerosPositivos = 0;

            for(int i = 0; i < 6; i++)
            {
                numeros = double.Parse(Console.ReadLine());

                if(numeros > 0)
                {
                    qtdNumerosPositivos++;
                }


            }
            Console.WriteLine($"{qtdNumerosPositivos} valores positivos"); 

  


        }
    }
}