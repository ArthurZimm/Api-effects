﻿using System.ComponentModel.DataAnnotations;

namespace api_effects.Data.Dtos
{
    public class UpdateRegistroDto
    {
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        
    }
}
