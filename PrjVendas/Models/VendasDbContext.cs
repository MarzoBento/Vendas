using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PrjVendas.Models
{
    public partial class VendasDbContext : DbContext
    {
        public VendasDbContext()
        {
        }

        public VendasDbContext(DbContextOptions<VendasDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acesso> Acessos { get; set; }
        public virtual DbSet<Cidade> Cidades { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=Desenvolvimento;Initial Catalog=Venda; Integrated Security=false;User ID=sa;Password=bento@72; pooling=false");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
