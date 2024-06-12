using System.ComponentModel.DataAnnotations;

namespace PlantProject.Models
{
    public class aestheticPlants
    {

        [Key]
        [Required]                  // study annotation, qysh me lidh me error displaying
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Please stick to using characters such as -Aa-")]
        public string Name { get; set; }


        [Required]
        public string Color { get; set; }

        [Required]
        public string Season { get; set; }

        [Required]
        public string Environment { get; set; }

        [Required]
        public string Introduction { get; set; }

        [Required]
        public string Care {  get; set; }

        public string Blooming { get; set; }

        public byte[]? Photo { get; set; }

        //vazhdoje  ma vone
        //levanshtajn
    }

}

     
