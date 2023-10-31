using Microsoft.EntityFrameworkCore;
using PrjVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjVendas
{
    public partial class Login : Form
    {

        private VendasDbContext _db = new VendasDbContext();

        public Login()
        {
            InitializeComponent();
        }

        private void cboempresa_Click(object sender, EventArgs e)
        {

            var cbo = (from a in _db.Acessos
                       join u in _db.Usuarios on a.UsuarioId equals u.UsuarioId
                       join em in _db.Empresas on a.EmpresaId equals em.EmpresaId
                       where a.EmpresaId == em.EmpresaId && a.EmpresaId == u.UsuarioId && u.Login == this.txtusuario.Text
                       select new { em.Nome, em.EmpresaId }).ToList();

            cboempresa.DataSource = cbo.ToList();
            cboempresa.DisplayMember = "Nome";
            cboempresa.ValueMember = "EmpresaId";


        }
    }
}
