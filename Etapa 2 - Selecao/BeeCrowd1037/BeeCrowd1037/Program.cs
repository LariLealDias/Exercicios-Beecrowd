﻿namespace exercicio1037
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valorEntrada = double.Parse(Console.ReadLine());

            if (valorEntrada >= 0 && valorEntrada <= 25)
            {
                Console.WriteLine($"Intervalo [0,25]");
            }
            else if (valorEntrada > 25 && valorEntrada <= 50)
            {
                Console.WriteLine($"Intervalo (25,50]");
            } 
            else if (valorEntrada > 50 && valorEntrada <= 75)
            {
                Console.WriteLine($"Intervalo (50,75]");            
            }else if(valorEntrada > 75 && valorEntrada <= 100)
            {
                Console.WriteLine($"Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}