namespace exercicio1038
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            string[] entrada = Console.ReadLine().Split(' ');
            
            int  codigo = int.Parse(entrada[0]);
            int  qtdItem = int.Parse(entrada[1]);

            double total = 0.0;

            if(codigo == 1)
            {
                total = 4.00 * qtdItem;
            } else if (codigo == 2)
            {
                total = 4.50 * qtdItem;
            }else if(codigo == 3)
            {
                total = 5.00 * qtdItem;
            } else if(codigo == 4)
            {
                total = 2.00 * qtdItem;
            }else if(codigo == 5)
            {
                total = 1.50 * qtdItem;
            }

            Console.WriteLine($"Total: R$ {total:F2}");
        }
    }
}