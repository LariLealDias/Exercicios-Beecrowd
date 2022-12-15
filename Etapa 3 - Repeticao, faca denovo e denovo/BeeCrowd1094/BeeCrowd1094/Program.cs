namespace exercicio1080
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int qtdCasos = int.Parse(Console.ReadLine());
            string[] caso;
            int totalRatos = 0;
            int totalSapos = 0;
            int totalCoelhos = 0;
            int quantidadeTotal;

            for (int i = 0; i < qtdCasos; i++)
            {


                caso = Console.ReadLine().Split();
                quantidadeTotal = int.Parse(caso[0]);

                if (caso[1] == "R")
                {
                    totalRatos += quantidadeTotal;
                   // Console.WriteLine($"verificar: {totalRatos}");
                } else if (caso[1] == "S")
                {
                    totalSapos+= quantidadeTotal;
                   // Console.WriteLine($"verificar: {totalSapos}");

                }
                else
                {
                    totalCoelhos += quantidadeTotal;
                   // Console.WriteLine($"verificar: {totalCoelhos}");

                }
            }

            double totalCobaias = totalCoelhos + totalRatos + totalSapos;
            double percentualCoelho = (totalCoelhos * 100) / totalCobaias;
            double percentualRatos = (totalRatos * 100) / totalCobaias;
            double percentualSapos = (totalSapos * 100) / totalCobaias;

            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {percentualCoelho:f2} %");
            Console.WriteLine($"Percentual de ratos: {percentualRatos:f2} %");
            Console.WriteLine($"Percentual de sapos: {percentualSapos:f2} %");


        }
    }
}