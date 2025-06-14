

namespace worker_contracts.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public decimal ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }
        public HourContract(DateTime date, decimal valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public decimal TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}