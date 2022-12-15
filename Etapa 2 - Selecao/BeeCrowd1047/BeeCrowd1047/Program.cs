namespace exercicio1047
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(entrada[0]);
            int minutoInicial = int.Parse(entrada[1]);
            int horaFinal = int.Parse(entrada[2]);
            int minutoFinal = int.Parse(entrada[3]);


            int duracaoHora = horaFinal - horaInicio;
            int duracaoMinuto = minutoFinal - minutoInicial;

            if (duracaoHora < 0)
            {
                duracaoHora = 24 + (horaFinal - horaInicio);

            } 
            if (duracaoMinuto < 0)
            {
                duracaoMinuto = 60 + (minutoFinal - minutoInicial);
                duracaoHora--;
            }

            if (duracaoHora == 0 && duracaoMinuto == 0)
            {
                duracaoHora = 24;
            }

            if (duracaoHora < 0)
            {
                duracaoHora = 24 + duracaoHora;
            }

            Console.WriteLine($"O JOGO DUROU {duracaoHora} HORA(S) E {duracaoMinuto} MINUTO(S)");
        }
    }
}