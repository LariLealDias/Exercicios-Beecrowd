namespace exercicio1040
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            string[] entrada = Console.ReadLine().Split(' ');

            double nota1ComPeso = double.Parse(entrada[0]) * 2;
            double nota2ComPeso = double.Parse(entrada[1]) * 3;
            double nota3ComPeso = double.Parse(entrada[2]) * 4;
            double nota4ComPeso = double.Parse(entrada[3]) * 1;

            double somaNotas = Math.Truncate(nota1ComPeso + nota2ComPeso + nota3ComPeso + nota4ComPeso);
            int somaPesos = 2 + 3 + 4 + 1;

            double media = somaNotas / somaPesos;
            //Math.Round e decimal nao funcionam, nomevariavel.ToString("0.0") tbm n funciona

            Console.WriteLine($"Media: {media:F1}");

            if(media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            } else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }else if(media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double notaExame = double.Parse(Console.ReadLine());
                Console.WriteLine($"Nota do exame: {notaExame:F1}");
                double mediaExame = (media + notaExame) / 2;
                if(mediaExame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                } else if(mediaExame <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {mediaExame:F1}");
            }
        }
    }
}