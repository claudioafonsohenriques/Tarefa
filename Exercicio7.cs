/*
    7-	Faça um programa em C#.net que se comporte como um vírus, 
    ou seja repete cada palavra que o usuário inseriu na frase.
   Exemplo
   Frase: Eu estou na Escola
   Saída: Eu Eu estou estou na na Escola Escola 

*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string fraseRepetida = RepetirPalavras(frase);

        Console.WriteLine("Frase repetida: {0}", fraseRepetida);
    }

    static string RepetirPalavras(string frase)
    {
        // Divide a frase em palavras usando os espaços em branco como separadores
        string[] palavras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Cria uma nova frase repetindo cada palavra
        string fraseRepetida = string.Join(" ", palavras);

        return fraseRepetida;
    }
}
