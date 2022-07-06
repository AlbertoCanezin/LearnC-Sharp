/*
using System;
using System.Globalization;

class Triangulo
{
    public double A;
    public double B;
    public double C;   
}

public class Calculo
{
    static void Main(string[] args) {
    Triangulo X, Y;
    X = new Triangulo();
    Y = new Triangulo();

    Console.WriteLine("Digite os números da área X: ");
    X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
    double p = (X.A + X.B + X.C) / 2;
    double areaX = Math.Sqrt(p * (p - X.A) * (p - X.B) * (p - X.C));

    Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    }
}
*/