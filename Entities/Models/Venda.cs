using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class Venda
    {
        public int VendaId { get; set; }
        public Usuario Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> Produtos { get; set; }

    }
}
