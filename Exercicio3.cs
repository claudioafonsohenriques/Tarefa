/*3-	Faça um programa em C#.net que receba uma frase. 
Caso a frase contenha nomes de meses por extenso substitua-os pelo seu número correspondente. 
Exemplo
Frase : No Mês de Julho faz muito frio 
Saída: No Mês de 07 faz muito frio 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string novaFrase = SubstituirMeses(frase);

        Console.WriteLine("Frase modificada: {0}", novaFrase);
    }

    static string SubstituirMeses(string frase)
    {
        // Array com os nomes dos meses por extenso
        string[] meses = { "janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };

        // Divide a frase em palavras usando os espaços em branco como separadores
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Percorre todas as palavras na frase
        for (int i = 0; i < palavras.Length; i++)
        {
            // Converte a palavra para minúsculas para fazer a comparação
            string palavraMin = palavras[i].ToLower();

            // Verifica se a palavra é um nome de mês
            for (int j = 0; j < meses.Length; j++)
            {
                if (palavraMin == meses[j])
                {
                    // Substitui o nome do mês pelo número correspondente
                    palavras[i] = (j + 1).ToString("00");
                    break;
                }
            }
        }

        // Junta as palavras de volta em uma nova frase
        string novaFrase = string.Join(" ", palavras);

        return novaFrase;
    }
}
