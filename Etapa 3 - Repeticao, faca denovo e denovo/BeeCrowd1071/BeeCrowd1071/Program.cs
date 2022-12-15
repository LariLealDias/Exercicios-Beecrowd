namespace exercicio1071
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int entrada1 = int.Parse(Console.ReadLine());
            int entrada2 = int.Parse(Console.ReadLine());

            /* nem sempre o valor que vai entrar na 1º variavel será menor, e para fazer a conta
            vai ser necessario começar com o menor valor (por isso a veficação)
            pois o exemplo é: x=6 e y=-5 e o resultado é 5
            ou seja, a conta feita sera: 
                    -3 -1 1 3 5
                não considera o proprio -5, por isso dentro da 1ºcondição do for a entrada1 precisa receber +1 
            */

            int soma = 0;

            if(entrada1 < entrada2)
            {
                for(int i = entrada1++; i < entrada2; i++)
                {
                    if(i % 2 != 0)
                    {
                        soma+= i;
                   //     Console.WriteLine($"soma do if{soma}");
                    }
                }
            }
            else
            {
                for(int i = entrada2 + 1; i < entrada1; i++)
                {
                    if(i % 2 != 0) 
                    {
                        soma+= i;
                      //  Console.WriteLine($"soma do else{soma}");
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}