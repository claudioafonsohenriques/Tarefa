/*
5-	Faça um programa em C#.net que receba uma frase e permite criptografar esta frase. 
    A  criptografia consiste em substituir todas as vogais por #.
Exemplo
Frase: Eu estou na Escola
Saída: ## #st## n# #sC#l#
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseCriptografada = CriptografarFrase(frase);

        Console.WriteLine("Frase criptografada: {0}", fraseCriptografada);
    }

    static string CriptografarFrase(string frase)
    {
        // Converte a frase para minúsculas para facilitar a comparação
        frase = frase.ToLower();

        // Array com as vogais
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

        // Percorre cada caractere da frase
        char[] caracteres = frase.ToCharArray();
        for (int i = 0; i < caracteres.Length; i++)
        {
            // Verifica se o caractere é uma vogal
            if (Array.IndexOf(vogais, caracteres[i]) != -1)
            {
                caracteres[i] = '#';
            }
        }

        // Cria a nova frase criptografada a partir dos caracteres modificados
        string fraseCriptografada = new string(caracteres);

        return fraseCriptografada;
    }
}
