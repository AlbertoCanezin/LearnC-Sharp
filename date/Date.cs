/*
using System;
using System.Globalization;

namespace Date
{
    public class Date
    {
        public static void Main(string[] args)
        {
            // Instanciando uma data ano, mes e dia
            DateTime d1 = new DateTime(2022, 07, 06);
            // Instanciando uma data ano, mes, dia, hora, minuto e segundo
            DateTime d2 = new DateTime(2022, 07, 06, 13, 36, 40);
            // Declarando uma data com horario atual
            DateTime d3 = DateTime.Now;
            // Declarando uma data com horario 00:00:00
            DateTime d4 = DateTime.Today;
            // Declarando uma data com o horario universal
            DateTime d5 = DateTime.UtcNow;

            // Usando o Parse
            DateTime d6 = DateTime.Parse("2000-08-15");
            DateTime d7 = DateTime.Parse("2000-08-15 13:05:58");

            // Colocando a data no formato BR
            DateTime d8 = DateTime.Parse("15/08/2000 13:05:58");

            // Declarando uma data e especificando a formatação
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
        }
    }
}
*/