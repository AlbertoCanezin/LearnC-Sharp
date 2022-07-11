/*
using System;

public class DomainException : ApplicationException
{
    public DomainException(string message) : base(message) {}
}

public class Reservation
{
    public int RooNumber { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    
    public Reservation() {}
    
    public Reservation(int rooNumber, DateTime checkIn, DateTime checkOut) 
    {
        if (checkOut <= checkIn)
        {
            throw new DomainException("Error in reservation: Check-out date must be after check-in");
        }
        RooNumber = rooNumber;
        CheckIn = checkIn;
        CheckOut = checkOut;
    }

    public int Duration() 
    {
        TimeSpan durantion = CheckOut.Subtract(CheckIn);
        return (int)durantion.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut) 
    {
        DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in");
            }

        CheckIn = checkIn;
        CheckOut = checkOut;
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
        try 
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.Write("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkIn, checkOut);
            System.Console.WriteLine("Reservation: " + reservation);
        } 
        catch(DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch(FormatException e)
        {
            Console.WriteLine("Format error " + e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }   
    }
}
*/
