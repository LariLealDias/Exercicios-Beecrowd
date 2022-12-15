namespace exercicio1099
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int qtdDeCasos = int.Parse(Console.ReadLine());
            int[] teste;
            int somaImpares = 0;
            int maior;
            int menor;


            for (int i = 0; i < qtdDeCasos; i++)
            {
                teste = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (teste[0] > teste[1])
                {
                    maior = teste[0];
                    menor = teste[1] + 1;
                }else if (teste[0] == teste[1])
                {
                    maior = teste[1];
                    menor = teste[0];
                }
                else
                {
                    menor = teste[0] + 1;
                    maior = teste[1];

                }


                while(maior > menor)
                {

                    if (menor % 2 != 0)
                    {
                        somaImpares += menor;
                    }
                    menor++;
                }
                Console.WriteLine(somaImpares);
                somaImpares = 0;
            }

        }
    }
}
