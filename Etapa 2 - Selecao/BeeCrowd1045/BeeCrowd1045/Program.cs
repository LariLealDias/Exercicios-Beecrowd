namespace exercicio145
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            double valorA = double.Parse(entrada[0]);
            double valorB = double.Parse(entrada[1]);
            double valorC = double.Parse(entrada[2]);

            double[] valoresOrdenados = new double[] { valorA, valorB, valorC };
            Array.Sort(valoresOrdenados);
            Array.Reverse(valoresOrdenados);

           // for(int i = 0; i < valoresOrdenados.Length; i++)
           // {
           //     Console.WriteLine(valoresOrdenados[i]);
           // }

            //reciclar variavel
            valorA = valoresOrdenados[0];
            valorB = valoresOrdenados[1];
            valorC = valoresOrdenados[2];

            bool doisLadosIguais = valorA == valorB || valorA == valorC || valorB == valorC;

            if (valorA >= valorB + valorC)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } else if(Math.Pow(valorA,2) == Math.Pow(valorB, 2) + Math.Pow(valorC, 2))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }else if(Math.Pow(valorA, 2) > Math.Pow(valorB, 2) + Math.Pow(valorC, 2))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }else if(Math.Pow(valorA, 2) < Math.Pow(valorB, 2) + Math.Pow(valorC, 2))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            } 
            if(valorA == valorB && valorA == valorC && valorB == valorC)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if (doisLadosIguais)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }



        }
    }
}