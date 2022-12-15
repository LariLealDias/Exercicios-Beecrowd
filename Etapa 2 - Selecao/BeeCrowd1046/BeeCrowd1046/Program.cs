namespace exercicio1046
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(entrada[0]);
            int horaFinal = int.Parse(entrada[1]);

            int inicioMaior = (24 - (horaInicio - horaFinal));
            int inicioMenor = horaFinal - horaInicio;

           
            if(horaInicio > horaFinal)
            {
                Console.WriteLine($"O JOGO DUROU {inicioMaior} HORA(S)");
            } else if(horaInicio == horaFinal)
            {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

            else
            {
                Console.WriteLine($"O JOGO DUROU {inicioMenor} HORA(S)");
            }
          


        }
    }
}