using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PrjVendas.Models
{
    [Table("Cliente")]
    [Index(nameof(CidadeId), Name = "IX_Cliente_cidadeId")]
    public partial class Cliente
    {
        [Key]
        [Column("clienteId")]
        public int ClienteId { get; set; }
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
        [Column("cidadeId")]
        public int CidadeId { get; set; }
        [Required]
        [Column("cep")]
        public string Cep { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("contato")]
        public string Contato { get; set; }
        [Required]
        [Column("telefone")]
        public string Telefone { get; set; }
        [Required]
        [Column("celular")]
        public string Celular { get; set; }
        [Required]
        [Column("responsavel")]
        public string Responsavel { get; set; }
        [Required]
        [Column("obs")]
        public string Obs { get; set; }
        [Required]
        [Column("dtcadastro")]
        public string Dtcadastro { get; set; }

        [ForeignKey(nameof(CidadeId))]
        [InverseProperty("Clientes")]
        public virtual Cidade Cidade { get; set; }
    }
}
