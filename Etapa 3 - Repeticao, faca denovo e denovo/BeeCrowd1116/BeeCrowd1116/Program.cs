namespace exercicio1116
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int quantidadeDeConjDeNumero = int.Parse(Console.ReadLine());
            int[] conjNumeros;
            double divisao;

            for(int i = 0; i < quantidadeDeConjDeNumero; i++)
            {
                conjNumeros = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (conjNumeros[1] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao =  (double)conjNumeros[0] / conjNumeros[1];
                    Console.WriteLine($"{divisao:f1}");
                }
            }


        }
    }
}