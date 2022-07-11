/* Este programa é uma solução ruim
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
        return (int)durantion.TotalDays;
    }

    public void UpdateDates(DateTime checkIn, DateTime checkOut) 
    {
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

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy)");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy)");
            checkOut = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
            }
            else if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in");
            }
            else 
            {
                reservation.UpdateDates(checkIn, checkOut);
                System.Console.WriteLine("Reservation: " + reservation);
            }
        }
    }
}
*/
