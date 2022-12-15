namespace exercicio1098
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double I = 0;
            double J = 0;
            int qtdVolta = 0;

            for (int i = 0; i < 60; i++)
            {
                if (qtdVolta > 2 && I > 1.8) break;

                if (qtdVolta > 2)
                {
                    qtdVolta = 1;
                    I += 0.2;
                    J = 1 + I;
                }
                else
                {
                    J++;
                    qtdVolta++;
                }
                if (J % 1 == 0)
                    //o resultado é int
                {
                    Console.WriteLine("I={0} J={1}", I, J);
                }
                else
                {
                    Console.WriteLine("I={0} J={1:0.0}", I, J);
                }
            }
        }
    }
}
