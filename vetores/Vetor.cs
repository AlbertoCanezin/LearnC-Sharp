/*
using System;
using System.Globalization;

namespace Vetor
{
    public class Vetor
    {
        static void Main(string[] args) {
            Console.Write("Qual o tamanho do vetor? ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            double soma = 0.0;
            double media = 0.0;

            for (var i = 0; i < n; i++)
            {
                Console.Write("Digite o número: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
            }

            for (var i = 0; i < n; i++)
            {
                soma += vect[i];
            }

            media = soma / n;

            Console.WriteLine($"A média é {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
*/