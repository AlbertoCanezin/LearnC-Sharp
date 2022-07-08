/*
using System;
using System.Collections.Generic;
using System.Globalization;

public class Employee
{
    public string Name { get; set; }
    public int Hours { get; set; }
    public double ValuePerHour { get; set; }    

    public Employee() {}

    public Employee(string name, int hours, double valuePerHour) 
    {
        Name = name;
        Hours = hours;
        ValuePerHour = valuePerHour;
    }

    public virtual double Payment()
    {
        return Hours * ValuePerHour;
    }
}

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee() {}

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        return base.Payment() + 1.1 + AdditionalCharge;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();

        Console.WriteLine("Enter the number od employees");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n ; i++)
        {
            Console.WriteLine($"Employee #{i} data: ");
            Console.Write("Outsourced (y/n)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'y') 
            {
                Console.Write("Additional charge: ");
                double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
            }
            else 
            {
                list.Add(new Employee(name, hours, valuePerHour));
            }
        }

        System.Console.WriteLine();
        System.Console.WriteLine("PAYMENTS: ");

        foreach (Employee emp in list)
        {
            Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
*/
