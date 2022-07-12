/*
using System;
using System.Globalization;

static class DateTimeExtensions
{
    // "this DateTime thisObj" este primeira parametro é uma referencia a classe DateTime apenas
    public static string ElapsedTime(this DateTime thisObj)
    {
        TimeSpan duration = DateTime.Now.Subtract(thisObj);
        if (duration.TotalHours < 24.0)
        {
            return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
        }
        else
        {
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = new DateTime(2021, 11, 16, 8, 10, 45);
        System.Console.WriteLine(dt.ElapsedTime());
    }
}
*/