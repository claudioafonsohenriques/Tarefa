/*
    8-	Faça um programa em C#.net e em cada ocorrência da palavra TECLADO 
    introduzir o texto OU MOUSE.
    Exemplo
    Frase: Pode-se usar o teclado para entrada de dados
    Saída: Pode-se usar o teclado ou mouse para entrada de dados

*/


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseModificada = SubstituirPalavra(frase, "teclado", "ou mouse");

        Console.WriteLine("Frase modificada: {0}", fraseModificada);
    }

    static string SubstituirPalavra(string frase, string palavraAlvo, string substituicao)
    {
        // Converte a frase para minúsculas para facilitar a comparação
        frase = frase.ToLower();

        // Divide a frase em palavras usando os espaços em branco como separadores
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Percorre todas as palavras na frase
        for (int i = 0; i < palavras.Length; i++)
        {
            // Converte a palavra para minúsculas para fazer a comparação
            string palavraMin = palavras[i].ToLower();

            // Verifica se a palavra é igual à palavra-alvo
            if (palavraMin == palavraAlvo)
            {
                // Substitui a palavra-alvo pela substituição desejada
                palavras[i] = substituicao;
            }
        }

        // Junta as palavras de volta em uma nova frase modificada
        string fraseModificada = string.Join(" ", palavras);

        return fraseModificada;
    }
}
