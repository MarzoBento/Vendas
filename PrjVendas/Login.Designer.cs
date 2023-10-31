namespace PrjVendas
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnCancelar = new Button();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            cboempresa = new ComboBox();
            groupBox3 = new GroupBox();
            txtsenha = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtusuario = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnEntrar);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 415);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Autenticação do Usuario";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(272, 317);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(120, 44);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(145, 317);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 44);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(10, 317);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(129, 44);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboempresa);
            groupBox4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.MidnightBlue;
            groupBox4.Location = new Point(10, 154);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(440, 65);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Empresa";
            // 
            // cboempresa
            // 
            cboempresa.FormattingEnabled = true;
            cboempresa.Location = new Point(6, 24);
            cboempresa.Name = "cboempresa";
            cboempresa.Size = new Size(428, 25);
            cboempresa.TabIndex = 0;
            cboempresa.Click += cboempresa_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtsenha);
            groupBox3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.MidnightBlue;
            groupBox3.Location = new Point(10, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(440, 65);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Senha";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(6, 20);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(428, 25);
            txtsenha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(10, 36);
            label1.Name = "label1";
            label1.Size = new Size(298, 30);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Gestão de Vendas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtusuario);
            groupBox2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(6, 83);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 65);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(6, 20);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(428, 25);
            txtusuario.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 420);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSair;
        private Button btnCancelar;
        private Button btnEntrar;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private ComboBox cboempresa;
        private GroupBox groupBox3;
        private TextBox txtsenha;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtusuario;
    }
}