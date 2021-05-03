using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        [Required]
        public String Nome { get; set; }
    }
}
