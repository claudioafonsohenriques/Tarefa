//4-	Faça um programa em C#.net que receba uma frase e 
//      calcule a quantidade de consoantes da frase digitada.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int quantidadeConsoantes = ContarConsoantes(frase);

        Console.WriteLine("A frase digitada contém {0} consoantes.", quantidadeConsoantes);
    }

    static int ContarConsoantes(string frase)
    {
        // Converte a frase para minúsculas para facilitar a comparação
        frase = frase.ToLower();

        int contador = 0;

        // Percorre cada caractere da frase
        foreach (char c in frase)
        {
            // Verifica se o caractere é uma consoante
            if (Char.IsLetter(c) && !IsVowel(c))
            {
                contador++;
            }
        }

        return contador;
    }

    static bool IsVowel(char c)
    {
        // Lista de vogais
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

        // Verifica se o caractere é uma vogal
        foreach (char vogal in vogais)
        {
            if (c == vogal)
            {
                return true;
            }
        }

        return false;
    }
}
