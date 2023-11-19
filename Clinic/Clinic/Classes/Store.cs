namespace Clinic.Classes
{
    public class Store
    {
        public string ProductName { get; set; } = null!;

        public DateTime? ExpirationDate { get; set; }

        public double Quantity { get; set; }

        public string UnitName { get; set; } = null!;
    }
}
