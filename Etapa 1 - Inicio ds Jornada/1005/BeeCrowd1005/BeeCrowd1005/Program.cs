namespace exercicio1005
{
    public class program
    {
        public static void Main(String[] args) 
        {
  
            double A = 3.5;
            double B = 7.5;

            double nota1 = A *  double.Parse(Console.ReadLine());
            double nota2 = B * double.Parse(Console.ReadLine());

            double resultadoNota = nota1 + nota2; 

             
            double media = (resultadoNota) / (A + B);
    

            Console.WriteLine($"MEDIA = {media:F5}");
        }
    }
}