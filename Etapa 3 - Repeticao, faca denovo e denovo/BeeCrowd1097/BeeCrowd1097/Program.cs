namespace exercicio1097
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int I = 1;
            int J = 7;
            int qtdVolta = 0;

                while(I <= 11)
                {
                if (I == 9 && qtdVolta == 3) break;

                        if(qtdVolta == 3)
                        {
                            qtdVolta= 0;
                            J += 5;
                            I += 2;
                        }
                    Console.WriteLine($"I={I} J={J}");
                    qtdVolta++;
                    J--;
                }
            




        }
    }
}
