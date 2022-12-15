namespace exercicio1114
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int senha;
          

            while (true)
            {
                senha = int.Parse(Console.ReadLine());
                if(senha == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }

        }
    }
}