namespace exercicio1035
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string valoresDeEntrada = Console.ReadLine();
            string[] valores = valoresDeEntrada.Split(' ');

            int A = int.Parse(valores[0]); 
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);
            int D = int.Parse(valores[3]);

            int somaCD = C + D;
            int somaAB = A + B;

            bool positivoC = (C >= 0);
            bool positivoD = (D >= 0);

            bool parA = (A % 2 == 0);

            if (B > C && D > A && somaCD > somaAB && positivoC && positivoD && parA)
            {
                Console.WriteLine("Valores aceitos");
            }else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
