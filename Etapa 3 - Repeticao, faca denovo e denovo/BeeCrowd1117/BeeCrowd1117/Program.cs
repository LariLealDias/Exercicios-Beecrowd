namespace exercicio1117
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double notas;
            double media;
            double notaAnterior = -1;
                                //zero é uma nota válida, por isso -1
            while (true)
            {
                notas = double.Parse(Console.ReadLine());

                if(notas >= 0 && notas <= 10)
                {
                    //é primeira vez que apareceu uma valida
                    if(notaAnterior == -1)
                    {
                        notaAnterior = notas;
                    }
                    else
                    {
                        media = (notaAnterior + notas) / 2;
                        Console.WriteLine($"media = {media:f2}");
                         break;
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
          

          

        }
    }
}