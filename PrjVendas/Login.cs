using Microsoft.EntityFrameworkCore;
using PrjVendas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text != "" & txtsenha.Text != "" & cboempresa.SelectedValue != null)
            {

                var obter = (from a in _db.Acessos
                             join u in _db.Usuarios on a.UsuarioId equals u.UsuarioId
                             join em in _db.Empresas on a.EmpresaId equals em.EmpresaId
                             where a.EmpresaId == em.EmpresaId && a.EmpresaId == u.UsuarioId && u.Login == this.txtusuario.Text && u.Senha == this.txtsenha.Text
                             select new { em.Nome, em.EmpresaId, u.Login, u.Senha }).ToList();


                foreach (var item in obter)
                {

                    if (item.Login == this.txtusuario.Text && item.EmpresaId == Convert.ToInt32(cboempresa.SelectedValue) && item.Senha == txtsenha.Text)
                    {


                        MDIPRincipal Principal = new MDIPRincipal(this);
                        Principal.FormClosing += new FormClosingEventHandler(Principal_FormClosing);
                        this.Visible = false;
                        Principal.ShowDialog();


                    }
                    else
                    {

                        MessageBox.Show("Dados Incorretos !");
                        txtusuario.Text = "";
                        txtsenha.Text = "";
                        txtusuario.Focus();



                    }

                }
                MessageBox.Show("Dados Incorretos !");
                txtusuario.Text = "";
                txtsenha.Text = "";
                cboempresa.SelectedIndex = -1;
                txtusuario.Focus();
            }
           


        }

        void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
