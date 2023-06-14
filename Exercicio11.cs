/*1-	Faça um programa que receba duas frases e gere uma terceira que represente 
        a combinação das palavras das duas frases lidas.
        Frase 1: Hoje está um belo dia 
        Frase 2: Talvez chova amanhã
        Saída : Hoje talvez está chova um amanhã belo dia
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira frase:");
        string frase1 = Console.ReadLine();

        Console.WriteLine("Digite a segunda frase:");
        string frase2 = Console.ReadLine();

        string fraseCombinada = CombinaFrases(frase1, frase2);

        Console.WriteLine("Frase combinada: {0}", fraseCombinada);
    }

    static string CombinaFrases(string frase1, string frase2)
    {
        // Divide as frases em palavras
        string[] palavrasFrase1 = frase1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] palavrasFrase2 = frase2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Verifica o número máximo de palavras a serem combinadas
        int maxPalavras = Math.Min(palavrasFrase1.Length, palavrasFrase2.Length);

        // Combina as palavras das duas frases
        string[] palavrasCombinadas = new string[maxPalavras * 2];
        int indice = 0;

        for (int i = 0; i < maxPalavras; i++)
        {
            palavrasCombinadas[indice++] = palavrasFrase1[i];
            palavrasCombinadas[indice++] = palavrasFrase2[i];
        }

        // Adiciona as palavras restantes da frase que tiver mais palavras
        if (palavrasFrase1.Length > maxPalavras)
        {
            Array.Copy(palavrasFrase1, maxPalavras, palavrasCombinadas, indice, palavrasFrase1.Length - maxPalavras);
        }
        else if (palavrasFrase2.Length > maxPalavras)
        {
            Array.Copy(palavrasFrase2, maxPalavras, palavrasCombinadas, indice, palavrasFrase2.Length - maxPalavras);
        }

        // Junta as palavras combinadas em uma única frase
        string fraseCombinada = string.Join(" ", palavrasCombinadas);

        return fraseCombinada;
    }
}
