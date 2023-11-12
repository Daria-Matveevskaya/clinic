using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities
{
    public class ExpenseItem
    {
        [Key]
        public int Id { get; set; }

        public int ExpenseId { get; set; }

        [StringLength(200)]
        public string ProductName { get; set; } = null!;

        [StringLength(50)]
        public string UnitName { get; set; } = null!;

        public double Quantity { get; set; }

        [ForeignKey("ExpenseId")]
        public virtual Expense Expense { get; set; } = null!;

        [ForeignKey("ProductName")]
        public virtual Product Product { get; set; } = null!;

        [ForeignKey("UnitName")]
        public virtual Unit Unit { get; set; } = null!;
    }
}
