namespace exercicio1060
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inicio do evento
            string[] numeroDiaInicio = Console.ReadLine().Split();
            int diaInicial = int.Parse(numeroDiaInicio[1]);
            string[] dataDiaInicio = Console.ReadLine().Split(':');

            int horaDiaInicio = int.Parse(dataDiaInicio[0]);
            int minutoDiaInicio = int.Parse(dataDiaInicio[1]);
            int segundoDiaInicio = int.Parse(dataDiaInicio[2]);

            //Final do evento
            string[] numeroDiaFinal = Console.ReadLine().Split();
            int diaFinal = int.Parse(numeroDiaFinal[1]);
            string[] dataDiaFinal = Console.ReadLine().Split(':');

            int horaDiaFinal = int.Parse(dataDiaFinal[0]);
            int minutoDiaFinal = int.Parse(dataDiaFinal[1]);
            int segundoDiaFinal = int.Parse(dataDiaFinal[2]);

            //calculos
            int totalDias = diaFinal - diaInicial;
            int totalMinutos = minutoDiaFinal - minutoDiaInicio;
            int totalHoras = horaDiaFinal - horaDiaInicio;
            int totalSegundos = segundoDiaFinal- segundoDiaInicio;

            if (totalSegundos < 0)
            {
                totalSegundos += 60;
                totalMinutos--;
            }

            if (totalMinutos < 0)
            {
                totalMinutos += 60;
                totalHoras--;
            }

            if (totalHoras < 0)
            {
                totalHoras += 24;
                totalDias--;
            }
            Console.WriteLine($"{totalDias} dia(s)\n{totalHoras} hora(s)\n{totalMinutos} minuto(s)\n{totalSegundos} segundo(s)");


            


        }
    }
}