/*
using System;
using System.Globalization;
using System.Collections.Generic;

public enum Color
{
    Black,
    Blue,
    Red
}

public abstract class Shape
{
    public Color Color { get; set; }
    
    public Shape(Color color)
    {
        Color = color;
    }

    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height, Color color) : base(color) 
    {
        Width = width;
        Height = height;
    }
        
    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius, Color color) : base(color)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();
        System.Console.Write("Enter the number of shapes: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            System.Console.Write($"Shape #{i} data: ");
            System.Console.Write("Rectangle or Circle (r/c)? ");
            char ch = char.Parse(Console.ReadLine());
            System.Console.Write("Color (Black/Blue/Red): ");
            Color color = Enum.Parse<Color>(Console.ReadLine());

            if (ch == 'r')
            {
                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Rectangle(width, height, color));
            }
            else
            {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Circle(radius, color));
            }
        }
        Console.WriteLine();
            System.Console.WriteLine("SHAPE AREAS");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));                
            }
    }
}
*/
