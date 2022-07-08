using System;

public class Reservation
{
    public int RooNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    
    public Reservation() {}
    
    public Reservation(int rooNumber, DateTime checkIn, DateTime checkOut) 
    {
        RooNumber = rooNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration() 
    {
        TimeSpan durantion = CheckOut.Subtract(CheckIn);
        return (int)durantion.TotalDays();
    }

    public override string ToString()
    {
        return "Roomm "
        + RooNumber
        + ", check-in: "
        + CheckIn.ToString("dd/MM/yyyy")
        + ", check-out: "
        + CheckOut.ToString("dd/MM/yyyy")
        + ", "
        + Duration()
        + " nights";
    }
    
}

public class ProcessFile
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Room number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check-in date (dd/MM/yyyy)");
        DateTime checkIn = DateTime.Parse(Console.ReadLine());
        Console.Write("Check-out date (dd/MM/yyyy)");
        DateTime checkOut = DateTime.Parse(Console.ReadLine());

        if (checkOut <= checkIn) 
        {
            Console.WriteLine("Error in reservation: Check-out date must be after check-in");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);
        }
    }
}