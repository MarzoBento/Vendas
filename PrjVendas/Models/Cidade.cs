using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PrjVendas.Models
{
    [Table("Cidade")]
    public partial class Cidade
    {
        public Cidade()
        {
            Clientes = new HashSet<Cliente>();
            Empresas = new HashSet<Empresa>();
        }

        [Key]
        [Column("cidadeId")]
        public int CidadeId { get; set; }
        [Required]
        [Column("nome")]
        public string Nome { get; set; }
        [Required]
        [Column("uf")]
        public string Uf { get; set; }

        [InverseProperty(nameof(Cliente.Cidade))]
        public virtual ICollection<Cliente> Clientes { get; set; }
        [InverseProperty(nameof(Empresa.Cidade))]
        public virtual ICollection<Empresa> Empresas { get; set; }
    }
}
