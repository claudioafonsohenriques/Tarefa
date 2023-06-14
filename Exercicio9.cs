/*
    9-	Faça um programa em C#.net que leia um nome complete e Abrevie os Nomes do meio.
        Exemplo
        Nome: Keyla Melanie Miguel Abel
        Saída: Keyla M. M. Abel 

*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um nome completo:");
        string nomeCompleto = Console.ReadLine();

        string nomeAbreviado = AbreviarNomesMeio(nomeCompleto);

        Console.WriteLine("Nome abreviado: {0}", nomeAbreviado);
    }

    static string AbreviarNomesMeio(string nomeCompleto)
    {
        // Divide o nome completo em partes usando os espaços em branco como separadores
        string[] partesNome = nomeCompleto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Verifica se o nome completo tem mais de 2 partes (considerando o primeiro e último nome)
        if (partesNome.Length > 2)
        {
            // Percorre todas as partes do nome, exceto o primeiro e último
            for (int i = 1; i < partesNome.Length - 1; i++)
            {
                // Obtém o nome do meio e abrevia para a primeira letra seguida de ponto
                string nomeMeio = partesNome[i];
                partesNome[i] = nomeMeio[0] + ".";
            }
        }

        // Junta as partes do nome de volta em um nome abreviado
        string nomeAbreviado = string.Join(" ", partesNome);

        return nomeAbreviado;
    }
}
