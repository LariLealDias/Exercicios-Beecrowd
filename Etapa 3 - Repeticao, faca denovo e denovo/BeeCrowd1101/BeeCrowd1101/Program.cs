namespace exercicio1101
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] conjNumeros;
            int maior;
            int menor;
            int soma;


            while (true)
            {
                soma = 0;

                conjNumeros = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (conjNumeros[0] <= 0 || conjNumeros[1] <= 0) break;

                if (conjNumeros[0] >= conjNumeros[1])
                {
                    maior = conjNumeros[0];
                    menor = conjNumeros[1];

                    for(int i = menor; i <= maior; i++)
                    {
                        Console.Write($"{i} ");
                        soma += i;
                    }
                   
                    Console.WriteLine($"Sum={soma}");

                }else if(conjNumeros[0] <= conjNumeros[1])
                {
                    maior = conjNumeros[1];
                    menor = conjNumeros[0];

                    for (int i = menor; i <= maior; i++)
                    {
                        Console.Write($"{i} ");
                        soma += i;
                    }

                    Console.WriteLine($"Sum={soma}");
                }
              

            }
                
            
 

        }
    }
}
