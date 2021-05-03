using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class StatusVenda
    {
        public int StatusVendaId { get; set; }

        [Required]
        public string Status { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
