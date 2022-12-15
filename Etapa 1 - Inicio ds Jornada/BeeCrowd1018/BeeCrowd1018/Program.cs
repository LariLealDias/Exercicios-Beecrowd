namespace exercicio1018
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int entrada = int.Parse(Console.ReadLine());

            int restante = entrada;

            int cem = 100;
            int cinquenta = 50;
            int vinte = 20;
            int dez = 10;
            int cinco = 5;
            int dois = 2;
            int um = 1;

            int qtdNotaCem = restante / cem;
            restante = restante - (cem * qtdNotaCem);

            int qtdNotaCinquenta = restante / cinquenta;
            restante = restante - (cinquenta * qtdNotaCinquenta);

            int qtdNotaVinte = restante / vinte;
            restante = restante - (vinte * qtdNotaVinte);

            int qtdNotaDez = restante / dez;
            restante = restante - (dez * qtdNotaDez);

            int qtdNotaCinco = restante / cinco;
            restante = restante - (cinco * qtdNotaCinco);

            int qtdNotaDois = restante / dois;
            restante = restante - (dois * qtdNotaDois);

            int qtdNotaUm = restante / um;
            restante = restante - (um * qtdNotaUm);

            Console.WriteLine(entrada);
            Console.WriteLine($"{qtdNotaCem} nota(s) de R$ 100,00");
            Console.WriteLine($"{qtdNotaCinquenta} nota(s) de R$ 50,00");
            Console.WriteLine($"{qtdNotaVinte} nota(s) de R$ 20,00");
            Console.WriteLine($"{qtdNotaDez} nota(s) de R$ 10,00");
            Console.WriteLine($"{qtdNotaCinco} nota(s) de R$ 5,00");
            Console.WriteLine($"{qtdNotaDois} nota(s) de R$ 2,00");
            Console.WriteLine($"{qtdNotaUm} nota(s) de R$ 1,00");
        }
    }
}