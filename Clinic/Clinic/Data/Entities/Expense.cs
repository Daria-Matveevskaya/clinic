using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Clinic.Data.Entities
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = null!;

        public virtual ObservableCollectionListSource<ExpenseItem> Items { get; } = new();
    }
}
