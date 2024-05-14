using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PlantProject.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Name { get; set; }

        [Required]
        [StringLength(80)]
        public string Paragraph { get; set; }

        [Required]
        public Color Color { get; set; }

        [Required]
        public Season Season { get; set; }

        [Required]
        public Type Type { get; set; }
        public string Care { get; set; }


        [Display(Name= "Side Effects")]
        public string? SideEffects { get; set; }


        public bool Health { get; set; }

        [Required]
        public string Photo { get; set; }



    }
}
