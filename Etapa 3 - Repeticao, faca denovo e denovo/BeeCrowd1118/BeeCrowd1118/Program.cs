namespace exercicio1118
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double notas;
            double media;
            double notaAnterior = -1;
            double notaAnteriorNovoCalculo = -1;
            int novoCalculo;

            while (true)
            {
                notas = double.Parse(Console.ReadLine());

                if (notas >= 0 && notas <= 10)
                {
                    if (notaAnterior == -1)
                    {
                        notaAnterior = notas;
                    }
                    else
                    {
                        media = (notaAnterior + notas) / 2;
                        Console.WriteLine($"media = {media:f2}");
                        while (true)
                        {
                            Console.WriteLine("novo calculo (1-sim 2-nao)");
                            novoCalculo = int.Parse(Console.ReadLine());
                            if (novoCalculo == 1 || novoCalculo == 2)
                            {
                                break;
                            }
                        }

                        if (novoCalculo == 2)
                        {
                            break;
                        }
                        else
                        {
                            notaAnterior = -1;
                        }
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