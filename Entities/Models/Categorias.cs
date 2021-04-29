using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    class Categorias
    {
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
