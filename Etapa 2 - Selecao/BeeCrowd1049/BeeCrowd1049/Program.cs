namespace exercicio1049
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string tipoAnimal1 = Console.ReadLine();
            string tipoAnimal2 = Console.ReadLine();
            string tipoAnimal3 = Console.ReadLine();

            if(tipoAnimal1 == "vertebrado")
            {
                if(tipoAnimal2 == "ave")
                {
                    if(tipoAnimal3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }else if(tipoAnimal2 == "mamifero")
                {
                    if(tipoAnimal3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            if(tipoAnimal1 == "invertebrado")
            {
                if(tipoAnimal2 == "inseto")
                {
                    if(tipoAnimal3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }else if(tipoAnimal2 == "anelideo")
                {
                    if(tipoAnimal3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
                
            }
        }
    }
}