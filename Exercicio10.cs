/*
    10-	Faça um programa em C#.net que receba um nome completo e reescreva-o 
    de acordo com a regra a seguir:
    Nome: Maria Silva Costa 
        Saída: Costa, Maria Silva 
    Nome: Maura Cristina Camilo Miguel Abel  
        Saída: Abel, Maura Cristina Camilo Miguel 

        Nesse caso De forma invertida

*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um nome completo:");
        string nomeCompleto = Console.ReadLine();

        string nomeReescrito = ReescreverNome(nomeCompleto);

        Console.WriteLine("Nome reescrito: {0}", nomeReescrito);
    }

    static string ReescreverNome(string nomeCompleto)
    {
        // Divide o nome completo em partes usando os espaços em branco como separadores
        string[] partesNome = nomeCompleto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Verifica se o nome completo tem mais de uma parte
        if (partesNome.Length > 1)
        {
            // Obtém o último nome
            string ultimoNome = partesNome[partesNome.Length - 1];

            // Move o último nome para a primeira posição
            Array.Copy(partesNome, 0, partesNome, 1, partesNome.Length - 1);
            partesNome[0] = ultimoNome;
        }

        // Junta as partes do nome de volta em um nome reescrito
        string nomeReescrito = string.Join(" ", partesNome);

        // Inverte a ordem do nome separado por vírgula
        string[] nomeSeparado = nomeReescrito.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(nomeSeparado);
        nomeReescrito = string.Join(", ", nomeSeparado);

        return nomeReescrito;
    }
}
