
using ProcessFile.Entities;
using ProcessFile.Entities.Exceptions;
using System.Globalization;

// IMPORTANT: This code will bring 3 methods of execution handling, with 1 being the most incorrect, 2 still not being ideal, but it is commonly used in old and non-object-oriented languages, and the 3rd method being the most appropriate.

//the 3rd solution, the most appropriate will be the uncommented solution and in effect in the code

try
{
    Console.Write("Room number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (dd/MM/yyyy) ");
    DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Check-out date (dd/MM/yyyy) ");
    DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);


    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine($"Resevation {reservation}");

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy) ");
    checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Check-out date (dd/MM/yyyy) ");
    checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    reservation.UpdateDates(checkIn, checkOut);

    Console.WriteLine("Reservation " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Format error: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Erro inesperado " + e.Message);
}


/*
    very bad logic
    solution 1

    Console.Write("Room number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Check-in date (dd/MM/yyyy) ");
DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Check-out date (dd/MM/yyyy) ");
DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

if (checkOut <= checkIn)
{
    Console.WriteLine("ERROR - check-out date must be after check-in date");
}
else
{
    Reservation reservation = new Reservation(number, checkIn, checkOut);
    Console.WriteLine($"Resevation {reservation}");

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation:");
    Console.Write("Check-in date (dd/MM/yyyy) ");
    checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    Console.Write("Check-out date (dd/MM/yyyy) ");
    checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

    string error = reservation.UpdateDates(checkIn, checkOut);
    if (error != null)
    {
        Console.Write("ERROR in reservation " + error);
    }
    else
    {
        Console.WriteLine("Reservation " + reservation);
    }
    DateTime now = DateTime.Now;
    if (checkIn < now || checkOut < now)
    {
        Console.WriteLine("Error in reservation: Reservation dates for update must be future date");
    }
    else if (checkOut <= checkIn)
    {
        Console.WriteLine("ERROR - check-out date must be after check-in date");
    }
    else
    {
        reservation.UpdateDates(checkIn, checkOut);
        Console.WriteLine("Reservation " + reservation);
    }

}
*/


