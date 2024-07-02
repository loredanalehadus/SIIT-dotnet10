using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Cupcakes.Models
{
    public class Cupcake
    {
        [Key]
        public int CupcakeId { get; set; }

        [Required(ErrorMessage = "Please select a cupcake type")]
        [Display(Name = "Cupcake Type:")]
        public CupcakeType? CupcakeType { get; set; }

        [Required(ErrorMessage = "Please enter a cupcake description")]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Display(Name = "Gluten Free:")]
        public bool GlutenFree { get; set; }

        [Display(Name = "Caloric Value:")]
        public int CaloricValue { get; set; }

        [Range(1, 15)]
        [Required(ErrorMessage = "Please enter a cupcake price")]
        [DataType(DataType.Currency)]
        [Display(Name = "Price:")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Please select a bakery")]
        public int? BakeryId { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual Bakery Bakery { get; set; }
    }
}
