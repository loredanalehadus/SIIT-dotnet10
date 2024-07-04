using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cupcakes.Entities
{
    public class Bakery
    {
        [Key]
        public int BakeryId { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public string BakeryName { get; set; }

        [Range(1, 40)]
        public int Quantity { get; set; }

        [StringLength(50, MinimumLength = 4)]
        public string Address { get; set; }

        [JsonIgnore]
        [NotMapped]
        public virtual ICollection<Cupcake> Cupcakes { get; set; }
    }
}
