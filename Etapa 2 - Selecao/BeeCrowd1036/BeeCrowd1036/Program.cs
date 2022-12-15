namespace exercicio1036{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string entrada = Console.ReadLine();
            string[] valores = entrada.Split(' ');

            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double valorDelta = Math.Pow(b, 2) - (4 * a * c);
            double raizDelta = Math.Sqrt(valorDelta);
            double numeroDivisao = 2 * a;

           // Console.WriteLine($"b: {b}");
            //Console.WriteLine($"Vdelta: {valorDelta}");
            //Console.WriteLine($"raiz: {raizDelta}");
            //Console.WriteLine($"numeroDivisao: {numeroDivisao}");


            double rAdicao = -b + raizDelta;
            //Console.WriteLine($"rAdicao: {rAdicao}");
            double r1 = rAdicao / numeroDivisao; 

            double rSubtracao = -b - raizDelta;
            //Console.WriteLine($"rSub: {rSubtracao}");
            double r2 = rSubtracao / numeroDivisao;


            bool numeroNaoCalculavel = (valorDelta <= 0 || numeroDivisao <= 0);
    
            
            if(numeroNaoCalculavel)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                 Console.WriteLine($"R1 = {r1:F5}");
                 Console.WriteLine($"R2 = {r2:F5}");
            }
        }
    }
}