using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Pole {nazwa} jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole {opis} jest wymagane")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Pole cena jest puste. Proszę uzupełnić")]
        public decimal Price { get; set; } = 0;
    }
}
