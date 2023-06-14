/*
    12-	Faça um programa que receba uma frase e coloque as palavras da frase em ordem crescente
        Exemplo: 
        Frase : A informática está em constante evolução
        Saída : A constante em está evolução informática

*/
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseOrdenada = OrdenarPalavras(frase);

        Console.WriteLine("Frase ordenada: {0}", fraseOrdenada);
    }

    static string OrdenarPalavras(string frase)
    {
        // Divide a frase em palavras
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Ordena as palavras em ordem alfabética
        Array.Sort(palavras);

        // Junta as palavras em uma nova frase ordenada
        string fraseOrdenada = string.Join(" ", palavras);

        return fraseOrdenada;
    }
}
