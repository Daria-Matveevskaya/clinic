using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Clinic.Data.Entities
{
    public class User
    {
        [Key]
        [StringLength(50)]
        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; } = null!;
    }
}
