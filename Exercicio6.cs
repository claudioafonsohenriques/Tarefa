/*
    6-	Faça um programa em C#.net que receba uma frase e uma palavra
        e calcule a ocorrência da palavra nesta frase.
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

        int ocorrencias = ContarOcorrencias(frase, palavra);

        Console.WriteLine("A palavra '{0}' ocorre {1} vezes na frase.", palavra, ocorrencias);
    }

    static int ContarOcorrencias(string frase, string palavra)
    {
        // Converte a frase e a palavra para minúsculas para facilitar a comparação
        frase = frase.ToLower();
        palavra = palavra.ToLower();

        int ocorrencias = 0;
        int indice = frase.IndexOf(palavra);

        while (indice != -1)
        {
            ocorrencias++;
            indice = frase.IndexOf(palavra, indice + 1);
        }

        return ocorrencias;
    }
}
