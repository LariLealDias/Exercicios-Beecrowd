namespace exercicio1019
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            int entradaSegundos = int.Parse(Console.ReadLine());

            int horas = entradaSegundos / 3600;
            int minutos = (entradaSegundos % 3600) / 60;
            int segundos = entradaSegundos % 60;
            
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}