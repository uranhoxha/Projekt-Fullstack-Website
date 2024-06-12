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
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage ="Please stick to using characters such as -Aa-")]
        public string? Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Paragraph { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string Season { get; set; }

        [Required]
        public string Type { get; set; }
        public string Care { get; set; }


        [Display(Name= "Side Effects")]
        public string? SideEffects { get; set; }


        public bool Health { get; set; }

        public byte[]? Photo { get; set; } 

    }
}
//algoritmi i levanshtajnit