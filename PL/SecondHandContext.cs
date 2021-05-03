using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PL
{
    public class SecondHandContext : DbContext
    {
        public SecondHandContext() : base()
        {
        }

        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<StatusVenda> StatusVenda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SecondHand;Trusted_Connection=True;");
        }
    }
}
