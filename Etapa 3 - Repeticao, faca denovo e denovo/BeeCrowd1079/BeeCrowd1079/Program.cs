namespace exercicio1079
{
    public class Program
    {
        static double calcularMediaPonderada(double numero1, double numero2, double numero3)
        {
            double[] peso = { 2.0, 3.0, 5, 0 };
            double somaPesos = peso[0] + peso[1] + peso[2];
            double mediaPonderada = (peso[0] * numero1 + peso[1] * numero2 + peso[2] * numero3) / somaPesos;
            return mediaPonderada;
        }

        public static void Main(string[] args)
        {


            int qtdTodalTestes = qtdTodalTestes = int.Parse(Console.ReadLine());
            double[] numeroDosTeste;
            //int.Parse(Console.ReadLine());
            // double[] segundoTeste = Array.ConvertAll( Console.ReadLine().Split(), S => double.Parse(S) );
            //double[] terceiroTeste = Array.ConvertAll( Console.ReadLine().Split(), S => double.Parse(S) );

            for (int i = 0; i < qtdTodalTestes; i++)
            {
                
                numeroDosTeste = Array.ConvertAll( Console.ReadLine().Split(), S => double.Parse(S) );
                double resultadoPrimeiroTeste = calcularMediaPonderada(numeroDosTeste[0], numeroDosTeste[1], numeroDosTeste[2]);
                Console.WriteLine($"{resultadoPrimeiroTeste:F1}");
            }

            //double resultadoSegundoTeste = calcularMediaPonderada(segundoTeste[0], segundoTeste[1], segundoTeste[2]);            
            //double resultadoterceiroTeste = calcularMediaPonderada(terceiroTeste[0], terceiroTeste[1], terceiroTeste[2]);

//            Console.WriteLine($" media: {resultadoSegundoTeste:F1}");
 //           Console.WriteLine($" media: {resultadoterceiroTeste:F1}");







        }
    }
}
