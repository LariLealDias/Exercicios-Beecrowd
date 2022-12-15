namespace exercicio1131
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] gols;
            int partidasVencidasInter = 0;
            int partidasVencidasGremio = 0;
            int decisao;
            int totalGrenais = 0;
            int totalEmpates = 0;

            while (true)
            {
                gols = Array.ConvertAll(Console.ReadLine().Split(), S => int.Parse(S));

                if (gols[0] > gols[1])
                {
                    partidasVencidasInter++;
                }else if (gols[0] == gols[1])
                {
                    totalEmpates++;
                }
                else
                {
                    partidasVencidasGremio++;
                }

                totalGrenais++;

                while (true)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    decisao = int.Parse(Console.ReadLine());

                    if(decisao == 2 || decisao == 1)
                    {
                        break;
                        //tem que dar break nos dois, pois no 1 vai reptir a pergunta dnovo
                        //se usuario apertar outro numero q nao esses vai repetir a pergunta tbm
                    }

                }

                if(decisao == 2)
                {
                    break;
                }

        }

                Console.WriteLine($"{totalGrenais} grenais");
            Console.WriteLine($"Inter:{partidasVencidasInter}");
            Console.WriteLine($"Gremio:{partidasVencidasGremio}");
            Console.WriteLine($"Empates:{totalEmpates}");

            if(partidasVencidasInter > partidasVencidasGremio)
            {
                 Console.WriteLine("Inter venceu mais");
            }
            else
            {
                Console.WriteLine("Gremio venceu mais");
            }




        }
    }
}