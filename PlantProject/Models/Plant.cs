using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PlantProject.Models
{
    public class Plant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Paragraph { get; set; }
        public Color Color { get; set; } 
        public Season Season { get; set; }
        public Type Type { get; set; }
        public string Care { get; set; }
        public string? SideEffects { get; set; }
        public bool Health { get; set; }
        public string Photo { get; set; }



    }
}
