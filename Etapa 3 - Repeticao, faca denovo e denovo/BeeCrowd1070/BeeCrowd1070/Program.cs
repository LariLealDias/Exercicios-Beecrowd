namespace exercicio1070
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* int numero = int.Parse(Console.ReadLine());
             int contador = 0;

             while(contador < 6)
             {
                 if(numero % 2 != 0)
                 {
                     Console.WriteLine(numero);
                     contador++;
                     //Console.WriteLine($"Contador: {contador}");
                 }
                // Console.WriteLine(numero);
                 numero++;
             } */




            int numero = int.Parse(Console.ReadLine());

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine($"i antes: {i}");
                if(numero % 2 != 0)
                {

                    Console.WriteLine(numero);
                   // Console.WriteLine($"o i++ é: {i++}"); 
                } else
                {
                    i--;
                }
                Console.WriteLine($"O N++ é: {numero++} e i é: {i}");
                
            }

     

        }
    }
}