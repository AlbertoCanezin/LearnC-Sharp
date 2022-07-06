/*
using System;
using System.Globalization;

public class Product
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Product(string nome, double preco) {
        Nome = nome;
        Preco = preco;
    }

    public override string ToString() {
        return "Nome: " + Nome + ",  $" + Preco.ToString("F2", CultureInfo.InvariantCulture);
    }
}


public class Vetor
{
    static void Main(string[] args) {
        Console.Write("Qual o tamanho do vetor? ");
        int n = int.Parse(Console.ReadLine());
        Product[] vect = new Product[n];

        for (var i = 0; i < n; i++)
        {
            Console.Write("Digite o nome do produto: ");
            string name = Console.ReadLine();
            Console.Write("Digite o preço do produto: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vect[i] = new Product(name, price);
        }

        double sum = 0.0;       

        for (var i = 0; i < n; i++)
        {
            sum += vect[i].Preco;
        }

        double avg = sum / n;

        Console.WriteLine($"A média dos preços é $ {avg.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}
*/