/*
using System;
using System.Globalization;

public interface ITaxService
{
    double Tax(double amount);
}

public class Vehicle
{
    public string Model { get; set; }

    public Vehicle(string model)
    {
        Model = model;
    }
}

public class Invoice
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }
    
    public Invoice(double basicPayment, double tax)
    {
        BasicPayment = basicPayment;
        Tax = tax;
    }
    
    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString()
    {
        return "Basic Payment: "
        + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
        + "\nTax: "
        + Tax.ToString("F2", CultureInfo.InvariantCulture)
        + "\nTotal payment: "
        + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
    }
}

public class CarRental
{
    public DateTime Start { get; set; }
    public DateTime Finish { get; set; }
    public Vehicle Vehicle { get; set; }
    public Invoice Invoice { get; set; }
    
    public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
    {
        Start = start;
        Finish = finish;
        Vehicle = vehicle;
    }    
}

// Realização de interfaces
public class BrazilTaxService : ITaxService
{
    public double Tax(double amount)
    {
        if (amount <= 100.0)
        {
            return amount * 0.2;
        }
        else
        {
            return amount * 0.15;
        }
    }
}

public class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }
    
    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
        _taxService = taxService;
    }

    private ITaxService _taxService;

    public void ProcessInvoice(CarRental carRental)
    {
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
        double basicPayment = 0.0;
        if (duration.TotalHours <= 12.0)
        {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
        }
        else
        {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = _taxService.Tax(basicPayment);
        carRental.Invoice = new Invoice(basicPayment, tax);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter rental data");
        System.Console.Write("Car model: ");
        string model = Console.ReadLine();
        Console.Write("Pickup (dd/MM/yyyy hh:mm)");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        Console.Write("Return (dd/MM/yyyy hh:mm)");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        System.Console.Write("Enter price per hour: ");
        
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        System.Console.Write("Enter price per day: ");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        System.Console.WriteLine("Invoice");
        System.Console.WriteLine(carRental.Invoice);
    }   
}
*/
