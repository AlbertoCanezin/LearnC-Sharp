/*
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Tier { get; set; }   
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category Category { get; set; }

    public override string ToString()
    {
        return Id
        + ", "
        + Name
        + ", "
        + Price.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Category.Name
        + ", "
        + Category.Tier;
    }   
}

public class Program
{
    public static void Main(string[] args)
    {
        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
        Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

        List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 },
        };

        var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00); 
        Print("TIER 1 AND PRICE < 900: ", r1);

        var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCTS FROM TOOLS: ", r2);

        var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT: ", r3);
        
        var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
        Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

        // Implementando um m??todo que faz o 'map e reduce' em javascript
        var r5 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
        Console.WriteLine("Categogy 1 aggregate sum: " + r5);
    }

    static void Print<T>(string message, IEnumerable<T> collection)
    {
        Console.WriteLine(message);
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }
}
*/
