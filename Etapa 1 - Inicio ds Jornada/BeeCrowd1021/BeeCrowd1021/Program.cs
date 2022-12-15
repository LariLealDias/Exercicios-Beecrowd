namespace exercicio1021
{
    public class Program
    {
        public static void Main(string[] args)
        {
           decimal entrada = decimal.Parse(Console.ReadLine());

            decimal restante = entrada;

            //NOTAS
            decimal NotaCem = 100.00m;
            decimal NotaCinquenta = 50.00m;
            decimal NotaVinte = 20.00m;
            decimal NotaDez = 10.00m;
            decimal NotaCinco = 5.00m;
            decimal NotaDois = 2.00m;

            int qtdNotaCem = (int)restante / (int)NotaCem;
            restante = restante - (NotaCem * qtdNotaCem);

            int qtdNotaCinquenta = (int)restante / (int)NotaCinquenta;
            restante = restante - (NotaCinquenta * qtdNotaCinquenta);

            int qtdNotaVinte = (int)restante / (int)NotaVinte;
            restante = restante - (NotaVinte * qtdNotaVinte);

            int qtdNotaDez = (int)restante / (int)NotaDez;
            restante = restante - (NotaDez * qtdNotaDez);

            int qtdNotaCinco = (int)restante / (int)NotaCinco;
            restante = restante - (NotaCinco * qtdNotaCinco);

            int qtdNotaDois = (int)restante / (int)NotaDois;
            restante = restante - (NotaDois * qtdNotaDois);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{qtdNotaCem} nota(s) de R$ 100.00");
            Console.WriteLine($"{qtdNotaCinquenta} nota(s) de R$ 50.00");
            Console.WriteLine($"{qtdNotaVinte} nota(s) de R$ 20.00");
            Console.WriteLine($"{qtdNotaDez} nota(s) de R$ 10.00");
            Console.WriteLine($"{qtdNotaCinco} nota(s) de R$ 5.00");
            Console.WriteLine($"{qtdNotaDois} nota(s) de R$ 2.00");

            //MOEDAS            
            decimal moedaUmReal = 1.00m;
            decimal moedaCinquenta = 0.50m * 100;
            decimal moedaVinteCinco = 0.25m * 100;
            decimal moedaDez = 0.10m * 100;
            decimal moedaCinco = 0.05m * 100;
            decimal moedaUmCentavo = 0.01m * 100;


             int qtdMoedaUmReal = (int)restante / (int)moedaUmReal;
             restante = restante - (moedaUmReal * qtdMoedaUmReal);

            //Multiplicando para trasformar as centenas em dezenas EX 0,10 * 100 = 10,00
            restante = restante * 100;

            int qtdMoedaCinquenta = (int)restante / (int)moedaCinquenta;
            restante = restante - (moedaCinquenta * qtdMoedaCinquenta);

           
            int qtdMoedaVinteCinco = (int)restante / (int)moedaVinteCinco;
            restante = restante - (moedaVinteCinco * qtdMoedaVinteCinco);

            int qtdMoedaDez = (int)restante / (int)moedaDez;
            restante = restante - (moedaDez * qtdMoedaDez);

            int qtdMoedaCinco = (int)restante / (int)moedaCinco;
            restante = restante - (moedaCinco * qtdMoedaCinco);

            int qtdMoedaUmCentavo = (int)restante / (int)moedaUmCentavo;
            restante = restante - (moedaUmCentavo * qtdMoedaUmCentavo);

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{qtdMoedaUmReal} moeda(s) de R$ 1.00");
            Console.WriteLine($"{qtdMoedaCinquenta} moeda(s) de R$ 0.50");
            Console.WriteLine($"{qtdMoedaVinteCinco} moeda(s) de R$ 0.25");
            Console.WriteLine($"{qtdMoedaDez} moeda(s) de R$ 0.10");
            Console.WriteLine($"{qtdMoedaCinco} moeda(s) de R$ 0.05");
            Console.WriteLine($"{qtdMoedaUmCentavo} moeda(s) de R$ 0.01");



        }
    }
}