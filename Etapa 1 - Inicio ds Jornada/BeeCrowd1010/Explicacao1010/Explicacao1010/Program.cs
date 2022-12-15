namespace explicacao1010
{
    public class Program
    {
        public static void Main(string[] args)
        {
                //Sobre Arrays
            // int[] array1 = new int[3];
                //int[] para declarar que é uma variavel array
                             //tem que ter a palavra new
                                    //[3] é a quantidade de elementos que terá  nesse array
                                  

                //um for para percorrer essa array e em cada loop colocar um elemento lido pelo console
            // for(int i = 0; i < array1.Length; i++)
            // {
            //    array1[i] = int.Parse(Console.ReadLine());
            //     Console.WriteLine($"numeros: {array1[i]}");
            // }
            // Console.WriteLine($"numeros: {array1}");


                //exercicio BeeCrowd
            //variaveis usadas nos dois casos
                //são os parametros do split
            int tamanhoMaximo = 3;
            string separador = " ";

            //PRODUTO 1
            string infoProduto1 = Console.ReadLine();
                    //aqui entra as infos do produto, consecultivamente: id, qtd, valor
            string[] resultado1 = infoProduto1.Split(separador, tamanhoMaximo);
                                               //split vai pegar o que tem de infoProduto1, 
                                                                        //separar o que é vazio da string (conforme declarado na variavel separador)
                                                                        
                                               //o split divide a cadeia de caracteres, precisa ser de uma string senão nao funciona
                                               //NÃO NECESSARIAMENTE PRECISA TER A DECLARAÇÃO DOS PARAMETROS, SÓ OS PARENTESES VAZIOS JÁ É
                                               //O SULFICIENTE PARA O SPLIT ENTENDER QUE É PARA TIRAR OS ESPAÇOS E CONTAR OS INDICES

            double resultadoSoma1 = double.Parse(resultado1[1]) * double.Parse(resultado1[2]);
                            //O enunciado pede o valor total considerando a qtd de peças
                            // ou seja, divide o elemento do indice 1 (qtd) pelo valor da peça unitaria(indice 2)
                            //precisa em ambos double.parse pq o resultado1 e 2 são string, ou seja, impossivel fazer conta com string
            Console.WriteLine($"resulstado: {resultadoSoma1}");

            //PROCUTO 2
            string infoProduto2 = Console.ReadLine();
            string[] resultado2 = infoProduto2.Split(separador, tamanhoMaximo);

            double resultadoSoma2 = double.Parse(resultado2[1]) * double.Parse(resultado2[2]);
            Console.WriteLine($"resulstado: {resultadoSoma2}");

            double total = resultadoSoma1 + resultadoSoma2;
            Console.WriteLine($"total é {total:F2}");
        }
    }
}