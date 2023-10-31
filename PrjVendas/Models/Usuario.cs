using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PrjVendas.Models
{
    [Table("Usuario")]
    public partial class Usuario
    {
        public Usuario()
        {
            Acessos = new HashSet<Acesso>();
        }

        [Key]
        [Column("usuarioId")]
        public int UsuarioId { get; set; }
        [Required]
        [Column("nome")]
        public string Nome { get; set; }
        [Required]
        [Column("email")]
        public string Email { get; set; }
        [Required]
        [Column("login")]
        public string Login { get; set; }
        [Required]
        [Column("senha")]
        public string Senha { get; set; }
        [Required]
        [Column("status")]
        public string Status { get; set; }

        [InverseProperty(nameof(Acesso.Usuario))]
        public virtual ICollection<Acesso> Acessos { get; set; }
    }
}
