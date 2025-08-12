namespace Enterprise.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public decimal ValuePerHour { get; set; }

        public Employee()
        { }
        public Employee(string name, int hours, decimal valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual decimal Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}