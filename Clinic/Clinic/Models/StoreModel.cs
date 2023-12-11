namespace Clinic.Models
{
    public class StoreModel
    {
        public string ProductName { get; set; } = null!;

        public string UnitName { get; set; } = null!;

        public DateTime? ExpirationDate { get; set; }

        public double Balance { get; set; }

        public bool IsExpiration { get => ExpirationDate != null && (ExpirationDate.Value - DateTime.Now).TotalDays < 60; }
    }
}
