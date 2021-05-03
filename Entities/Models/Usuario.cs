using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
