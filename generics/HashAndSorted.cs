/*
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() {0, 2, 4, 5, 6, 8, 10};
        SortedSet<int> b = new SortedSet<int>() {5, 6, 7, 8, 9, 10};

        PrintCollection(a);

        // Union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);
        PrintCollection(c);

        // intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintCollection(d);

        // Difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintCollection(e);
    }

    // IEnumerable é uma interface implementada pelo System.Collections
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
    }
}
*/
