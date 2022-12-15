namespace exercicio1050
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //cada % sobre o valor é baseado na sobra (else)
            //enquanto o if é baseado no valor fixo (if)



            double renda = double.Parse(Console.ReadLine());
            double sobraRenda = 0;

           if (renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            } else
            {
                sobraRenda = renda - 2000.00;
            }

           if (sobraRenda > 0) 
            {
                double imposto;

                if (sobraRenda > 1000.00)
                {
                    //sobraRenda = sobraRenda - 1000
                    sobraRenda -= 1000;

                    // valor inposto 8% sobre 1000
                    imposto = (8 * 1000) / 100;

                    if (sobraRenda > 1500)
                    {
                        //sobraRenda =sobraRenda - 1500
                        sobraRenda -= 1500;

                        //valor inposto 18% sobre 1500
                        imposto += (18 * 1500) / 100;

                        if (sobraRenda > 0)
                        {
                            //valor inposto 28% sobre 100
                            imposto += (28 * sobraRenda) / 100;
                        }
                    }
                    else
                    {
                        //valor inposto 18% sobraRenda
                        imposto += (18 * sobraRenda) / 100;
                    }
                }
                else
                {
                    //valor inposto 8% sobraRenda
                    imposto = (8 * sobraRenda) / 100;


                }
                Console.WriteLine($"R$ {imposto:F2}");
            }
            

        }
    }
}