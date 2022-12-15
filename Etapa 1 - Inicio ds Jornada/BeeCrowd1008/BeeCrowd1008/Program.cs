namespace exercicio1008
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            int idFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhas = int.Parse(Console.ReadLine());
            double valorPorHora = double.Parse(Console.ReadLine());

            double salario = valorPorHora * horasTrabalhas;

            Console.WriteLine($"NUMBER = {idFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}