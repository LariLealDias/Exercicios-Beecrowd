namespace exercicio1020
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int ano = idadeEmDias / 365;
            int mes = (idadeEmDias % 365) / 30;
            int dia = (idadeEmDias % 365) % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
