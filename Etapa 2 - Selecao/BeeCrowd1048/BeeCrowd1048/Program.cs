namespace exercicio1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double salarioAtual = double.Parse(Console.ReadLine());
            double percentual;
            double percentualDeReajuste;

            if (salarioAtual == 0 || salarioAtual <= 400.00)
            {
                percentual = 15;
            } 
            else if(salarioAtual >= 400.01 && salarioAtual <= 800.00)
            {
                percentual = 12;
            } 
            else if(salarioAtual >= 800.01 && salarioAtual <= 1200.00)
            {
                percentual = 10;
            } 
            else if (salarioAtual >= 1200.01 && salarioAtual <= 2000.00)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }

            percentualDeReajuste = (percentual * salarioAtual) / 100;
            double salarioAjuste = salarioAtual + percentualDeReajuste;
            double reajusteGanho = salarioAjuste - salarioAtual;

            Console.WriteLine($"Novo salario: {salarioAjuste:F2}");
            Console.WriteLine($"Reajuste ganho: {reajusteGanho:F2}");
            Console.WriteLine($"Em percentual: {percentual} %");


        }
    }
}