/*
using System;
using System.Collections.Generic;

public class List
{
    static void Main(string[] args) {
        List<string> list = new List<string>();

        // Por padrão o método Add adicona um elemento ao final da lista
        list.Add("Alberto");
        list.Add("Flávia");
        list.Add("Neusa");

        // O método insert podemos adicionar um elemento em uma posição especifica
        list.Insert(0, "Jesus Cristo");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        // Count é uma propriedade que retorna o tamanho da lista 
        Console.WriteLine("Tamanho da lista: " + list.Count);

        // Find é um método que retorna uma ocorrencia especifica, podemos passar uma função lambda como callback
        string s1 = list.Find(x => x[0] == 'A');
        Console.WriteLine($"First 'A': {s1}");

        // FindLast é um metodo que retorna a ultima ocorrencia especifica
        string s2 = list.FindLast(x => x[0] == 'N');
        Console.WriteLine($"Last 'N': {s2}");

        // FindIndex e FindLastIndex retorna a primeira ou o ultimo elemento que satisfaz um predicado
        int pos1 = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A': " + pos1);
        int pos2 = list.FindLastIndex(x => x[0] == 'A');
        Console.WriteLine("First position 'A': " + pos2);

        Console.WriteLine("-------------------------");

        // Usando o método FindAll para retornar uma nova lista que satisfaz um predicado
        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach (string obj in list2)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("--------------------------");

        // Removendo um item da lista com o método Remove
        list.Remove("Alberto");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("--------------------------");

        // Removendo varios itens da lista com o método RemoveAll
        list.RemoveAll(x => x[0] == 'F');
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("--------------------------");

        // Removendo um elemento conforme a sua posição
        list.RemoveAt(1);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("--------------------------");

        // Removendo varios elementos conforme a sua posição e a quantidade passada
        list.RemoveRange(0, 1);
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}
*/