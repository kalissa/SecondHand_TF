using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class StatusVenda
    {
        public int StatusVendaId { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }
    }
}
