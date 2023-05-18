using System.ComponentModel.DataAnnotations;

namespace api_effects.Models
{
    public class Registro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        

    }
}
