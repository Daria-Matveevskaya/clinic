using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Clinic.Data.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int ProviderId { get; set; }

        [ForeignKey("ProviderId")]
        public virtual Provider Provider { get; set; } = null!;

        public virtual ObservableCollectionListSource<RecipeItem> RecipeItems { get; } = new();
    }
}
