using System;
using ProcessFile.Entities.Exceptions;


namespace ProcessFile.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException ("Check-out date must be after check-in date");
            }
            
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            /*
            bad logic 
            solution 2
            
            OBS: for this solution, this method need return a string, not a void method, like this:

                    public string UpdateDates(DateTime checkIn, DateTime checkOut)

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Dates for update must be future date";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after check-in date";
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
            */


            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException ("Dates for update must be future date");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException ("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}