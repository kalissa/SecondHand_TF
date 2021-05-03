using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required]
        public int DescricaoProd { get; set; }
        [Required]
        public double Valor { get; set; }
    }
}
