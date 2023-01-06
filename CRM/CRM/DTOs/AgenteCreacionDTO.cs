﻿using System.ComponentModel.DataAnnotations;

namespace CRM.DTOs
{
    public class AgenteCreacionDTO
    {
        [Required]
        [StringLength(70, ErrorMessage = "El campo {0} no debe exceder de {1} caracteres.")]
        public string Nombre { get; set; }
    }
}
