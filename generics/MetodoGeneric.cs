/*
using System;
using System.Collections.Generic;

public class CalculationService
{
    public T Max<T>(List<T> list) where T : IComparable
    {
        if (list.Count == 0)
        {
            throw new ArgumentException("The list can not be empty");
        }

        T max = list[0];
        for (var i = 0; i < list.Count; i++)
        {
            if (list[i].CompareTo(max) > 0)
            {
                max = list[i];
            }
        }
        return max;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            list.Add(x);
        }

        CalculationService calculationService = new CalculationService();

        int max = calculationService.Max(list);
        Console.WriteLine("Max: ");
        Console.WriteLine(max);
    }
}
*/
