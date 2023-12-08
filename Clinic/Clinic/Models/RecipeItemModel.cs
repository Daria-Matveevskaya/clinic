namespace Clinic.Models
{
    public class RecipeItemModel
    {
        public bool IsChecked { get; set; }
        public string ProductName { get; set; } = null!;

        public string UnitName { get; set; } = null!;

        public DateTime? ExpirationDate { get; set; }

        public double Quantity { get; set; }

        public int? Id { get; set; }
    }
}
