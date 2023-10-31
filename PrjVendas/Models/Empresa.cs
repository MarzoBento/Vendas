using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PrjVendas.Models
{
    [Table("Empresa")]
    [Index(nameof(CidadeId), Name = "IX_Empresa_cidadeId")]
    public partial class Empresa
    {
        public Empresa()
        {
            Acessos = new HashSet<Acesso>();
        }

        [Key]
        [Column("empresaId")]
        public int EmpresaId { get; set; }
        [Required]
        [Column("nome")]
        public string Nome { get; set; }
        [Required]
        [Column("cpfcnpj")]
        public string Cpfcnpj { get; set; }
        [Required]
        [Column("inscestadual")]
        public string Inscestadual { get; set; }
        [Required]
        [Column("inscmunicipal")]
        public string Inscmunicipal { get; set; }
        [Required]
        [Column("endereco")]
        public string Endereco { get; set; }
        [Required]
        [Column("bairro")]
        public string Bairro { get; set; }
        [Required]
        [Column("cep")]
        public string Cep { get; set; }
        [Column("cidadeId")]
        public int CidadeId { get; set; }
        [Required]
        [Column("fone")]
        public string Fone { get; set; }
        [Required]
        [Column("ramal")]
        public string Ramal { get; set; }
        [Required]
        [Column("celular")]
        public string Celular { get; set; }
        [Required]
        [Column("contato")]
        public string Contato { get; set; }
        [Required]
        [Column("fax")]
        public string Fax { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("data")]
        public string Data { get; set; }

        [ForeignKey(nameof(CidadeId))]
        [InverseProperty("Empresas")]
        public virtual Cidade Cidade { get; set; }
        [InverseProperty(nameof(Acesso.Empresa))]
        public virtual ICollection<Acesso> Acessos { get; set; }
    }
}
