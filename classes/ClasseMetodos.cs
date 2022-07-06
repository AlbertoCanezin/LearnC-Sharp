/*
using System;
using System.Globalization;

class Triangulo
{
    public double A;
    public double B;
    public double C;

    public double Area() {
        double p = (A + B + C) / 2;
        double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return raiz;
    }   
}

public class Program
{
    static void Main(string[] args) {
    Triangulo x;
    x = new Triangulo();

    Console.WriteLine("Digite os números da área X: ");
    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    double areaX = x.Area();

    Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    }
}
*/