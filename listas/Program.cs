using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();

        //Adicidionando elemnetos 
        nomes.Add("Ana");
        nomes.Add("Bruno");
        nomes.Add("Carlos");

        Console.WriteLine(nomes[0]);
        Console.WriteLine(nomes[1]);
        Console.WriteLine(nomes[2]);

        Console.WriteLine("\nLista após adicionar elementos:");
        foreach(string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Adiciona novo nome
        nomes.Add("Daniel");

        Console.WriteLine("\nLista após adicionar Daniel:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        //Removendo elementos
        nomes.Remove("Bruno"); // remove pelo valor
        Console.WriteLine("\nLista após remover Bruno");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }

        // Removendo pelo índice
        nomes.RemoveAt(0); // remove o primeiro (Ana)
        Console.WriteLine("\nLista após remover o índice 0 (Ana):");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        //Limpando toda a lista
        nomes.Clear();

        Console.WriteLine("\nLista após Clear():");
        Console.WriteLine($"Quantidade de elementos: {nomes.Count}");
    }
}