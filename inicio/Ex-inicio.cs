/*
using System;
using System.Globalization;

namespace NET
{
    class ExEntrada
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto:");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu último nome, idade e altura:");
            string[] vetor = Console.ReadLine().Split();
            string lastName = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine($"{lastName} {idade} {altura}");
        }
    }
}
*/