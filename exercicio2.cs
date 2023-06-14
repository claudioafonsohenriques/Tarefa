/*2-	Faça um programa em C#.net que receba uma frase e uma palavra. 
Caso a frase contenha a palavra ESCOLA substitua pela palavra digitada.
Exemplo: 
Frase: EU MORO PERTO DE UMA ESCOLA, MAS ESTA ESCOLA NÃO É A MELHOR
Palavra: PADARIA
Saída: EU MORO PERTO DE UMA PADARIA, MAS ESTA PADARIA NÃO É A MELHOR 
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        string novaFrase = SubstituirPalavra(frase, "ESCOLA", palavra);

        Console.WriteLine("Frase modificada: {0}", novaFrase);
    }

    static string SubstituirPalavra(string frase, string palavraAntiga, string palavraNova)
    {
        // Divide a frase em palavras usando os espaços em branco como separadores
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Percorre todas as palavras na frase
        for (int i = 0; i < palavras.Length; i++)
        {
            // Verifica se a palavra atual é igual à palavra antiga (ignorando maiúsculas/minúsculas)
            if (string.Equals(palavras[i], palavraAntiga, StringComparison.OrdinalIgnoreCase))
            {
                // Substitui a palavra antiga pela nova palavra
                palavras[i] = palavraNova;
            }
        }

        // Junta as palavras de volta em uma nova frase
        string novaFrase = string.Join(" ", palavras);

        return novaFrase;
    }
}
