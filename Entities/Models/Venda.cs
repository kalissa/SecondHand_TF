using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        [Required]
        public Usuario Cliente { get; set; }
        [Required]
        public Vendedor Vendedor { get; set; }
        [Required]
        public List<Produto> Produtos { get; set; }

    }
}
