/*
using System;
using System.Globalization;

namespace NET
{
    class Inicio
    {
        static void Main(string[] args)
        {
            
            string frase = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine($"{nome} é do sexo {sexo}, tem {idade} anos e tem {altura} metrôs de altura.");
        }
    }
}
*/