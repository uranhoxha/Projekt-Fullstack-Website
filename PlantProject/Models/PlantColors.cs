using System.ComponentModel.DataAnnotations;

namespace PlantProject.Models
{
    public class PlantColors
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string hexValue { get; set; }
    }
}
