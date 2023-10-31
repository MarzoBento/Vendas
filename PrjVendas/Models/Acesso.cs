using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PrjVendas.Models
{
    [Index(nameof(EmpresaId), Name = "IX_Acessos_empresaId")]
    [Index(nameof(UsuarioId), Name = "IX_Acessos_usuarioId")]
    public partial class Acesso
    {
        [Key]
        [Column("menuId")]
        public int MenuId { get; set; }
        [Required]
        [Column("menu")]
        public string Menu { get; set; }
        [Required]
        [Column("submenu")]
        public string Submenu { get; set; }
        [Column("permissao")]
        public bool Permissao { get; set; }
        [Column("usuarioId")]
        public int UsuarioId { get; set; }
        [Column("empresaId")]
        public int EmpresaId { get; set; }

        [ForeignKey(nameof(EmpresaId))]
        [InverseProperty("Acessos")]
        public virtual Empresa Empresa { get; set; }
        [ForeignKey(nameof(UsuarioId))]
        [InverseProperty("Acessos")]
        public virtual Usuario Usuario { get; set; }
    }
}
