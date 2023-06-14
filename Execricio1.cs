/*1-	Faça um programa em C#.net que receba um texto 
ou uma frase e calcule a quantidade de palavras da frase digitada. */
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int quantidadePalavras = ContarPalavras(frase);

        Console.WriteLine("A frase digitada contém {0} palavras.", quantidadePalavras);
    }

    static int ContarPalavras(string frase)
    {
        // Remove espaços em branco adicionais no início e no fim da frase
        frase = frase.Trim();

        // Verifica se a frase está vazia
        if (frase.Length == 0)
        {
            return 0;
        }

        // Divide a frase em palavras usando os espaços em branco como separadores
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Retorna a quantidade de palavras
        return palavras.Length;
    }
}
