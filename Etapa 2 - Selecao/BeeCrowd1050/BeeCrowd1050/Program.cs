namespace exercicio1050
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int codigoDDD = int.Parse(Console.ReadLine());

            if(codigoDDD == 61)
            {
                Console.WriteLine("Brasilia");
            }else if(codigoDDD == 71)
            {
                Console.WriteLine("Salvador");
            }else if(codigoDDD == 11)
            {
                Console.WriteLine("Sao Paulo");
            }else if(codigoDDD == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }else if(codigoDDD == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }else if(codigoDDD == 19)
            {
                Console.WriteLine("Campinas");
            }else if(codigoDDD == 27)
            {
                Console.WriteLine("Vitoria");
            }else if(codigoDDD == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }


        }
    }
}