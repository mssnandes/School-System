namespace School_Project
{
    partial class frmTelaMenu
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
            this.pcbLogoSchoolSys = new System.Windows.Forms.PictureBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.lblOla = new System.Windows.Forms.Label();
            this.pcbBotaoCadastros = new System.Windows.Forms.PictureBox();
            this.pcbBotaoSair = new System.Windows.Forms.PictureBox();
            this.pcbBotaoPesquisar = new System.Windows.Forms.PictureBox();
            this.pcbBotaoNotasFrequências = new System.Windows.Forms.PictureBox();
            this.pcbBolaFoto = new System.Windows.Forms.PictureBox();
            this.lblNomeLogado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoNotasFrequências)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolaFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLogoSchoolSys
            // 
            this.pcbLogoSchoolSys.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogoSchoolSys.Image = global::School_Project.Properties.Resources.Logo_SchooSys_21;
            this.pcbLogoSchoolSys.Location = new System.Drawing.Point(4, -2);
            this.pcbLogoSchoolSys.Name = "pcbLogoSchoolSys";
            this.pcbLogoSchoolSys.Size = new System.Drawing.Size(64, 64);
            this.pcbLogoSchoolSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoSchoolSys.TabIndex = 14;
            this.pcbLogoSchoolSys.TabStop = false;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.lblAdministrador.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.ForeColor = System.Drawing.Color.White;
            this.lblAdministrador.Location = new System.Drawing.Point(210, 52);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(190, 33);
            this.lblAdministrador.TabIndex = 16;
            this.lblAdministrador.Text = "Administrador";
            this.lblAdministrador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.BackColor = System.Drawing.Color.Transparent;
            this.lblOla.Font = new System.Drawing.Font("Ubuntu", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblOla.ForeColor = System.Drawing.Color.White;
            this.lblOla.Location = new System.Drawing.Point(211, 17);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(82, 41);
            this.lblOla.TabIndex = 15;
            this.lblOla.Text = "Olá!";
            this.lblOla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbBotaoCadastros
            // 
            this.pcbBotaoCadastros.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoCadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoCadastros.Image = global::School_Project.Properties.Resources.Ícone_Cadastros_Aceso;
            this.pcbBotaoCadastros.Location = new System.Drawing.Point(38, 195);
            this.pcbBotaoCadastros.Name = "pcbBotaoCadastros";
            this.pcbBotaoCadastros.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoCadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoCadastros.TabIndex = 20;
            this.pcbBotaoCadastros.TabStop = false;
            this.pcbBotaoCadastros.Click += new System.EventHandler(this.pcbBotãoCadastros_Click);
            // 
            // pcbBotaoSair
            // 
            this.pcbBotaoSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBotaoSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoSair.Image = global::School_Project.Properties.Resources.Ícone_Sair_Aceso;
            this.pcbBotaoSair.Location = new System.Drawing.Point(38, 375);
            this.pcbBotaoSair.Name = "pcbBotaoSair";
            this.pcbBotaoSair.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoSair.TabIndex = 19;
            this.pcbBotaoSair.TabStop = false;
            this.pcbBotaoSair.Click += new System.EventHandler(this.pcbBotãoSair_Click);
            // 
            // pcbBotaoPesquisar
            // 
            this.pcbBotaoPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoPesquisar.Image = global::School_Project.Properties.Resources.Ícone_Pesquisar_Aceso;
            this.pcbBotaoPesquisar.Location = new System.Drawing.Point(38, 315);
            this.pcbBotaoPesquisar.Name = "pcbBotaoPesquisar";
            this.pcbBotaoPesquisar.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoPesquisar.TabIndex = 18;
            this.pcbBotaoPesquisar.TabStop = false;
            this.pcbBotaoPesquisar.Click += new System.EventHandler(this.pcbBotãoPesquisar_Click);
            // 
            // pcbBotaoNotasFrequências
            // 
            this.pcbBotaoNotasFrequências.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoNotasFrequências.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoNotasFrequências.Image = global::School_Project.Properties.Resources.Ícone_NotasFrequêcias_Aceso;
            this.pcbBotaoNotasFrequências.Location = new System.Drawing.Point(38, 255);
            this.pcbBotaoNotasFrequências.Name = "pcbBotaoNotasFrequências";
            this.pcbBotaoNotasFrequências.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoNotasFrequências.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBotaoNotasFrequências.TabIndex = 17;
            this.pcbBotaoNotasFrequências.TabStop = false;
            this.pcbBotaoNotasFrequências.Click += new System.EventHandler(this.pcbBotãoNotasFrequências_Click);
            // 
            // pcbBolaFoto
            // 
            this.pcbBolaFoto.BackColor = System.Drawing.Color.Transparent;
            this.pcbBolaFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBolaFoto.Image = global::School_Project.Properties.Resources.Bola_de_Foto;
            this.pcbBolaFoto.Location = new System.Drawing.Point(45, 66);
            this.pcbBolaFoto.Name = "pcbBolaFoto";
            this.pcbBolaFoto.Size = new System.Drawing.Size(95, 93);
            this.pcbBolaFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolaFoto.TabIndex = 108;
            this.pcbBolaFoto.TabStop = false;
            this.pcbBolaFoto.Click += new System.EventHandler(this.pcbBolaFoto_Click);
            // 
            // lblNomeLogado
            // 
            this.lblNomeLogado.AutoSize = true;
            this.lblNomeLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeLogado.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLogado.ForeColor = System.Drawing.Color.White;
            this.lblNomeLogado.Location = new System.Drawing.Point(71, 167);
            this.lblNomeLogado.Name = "lblNomeLogado";
            this.lblNomeLogado.Size = new System.Drawing.Size(44, 17);
            this.lblNomeLogado.TabIndex = 109;
            this.lblNomeLogado.Text = "Nome";
            this.lblNomeLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Project.Properties.Resources.Tela_de_Menu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeLogado);
            this.Controls.Add(this.pcbBolaFoto);
            this.Controls.Add(this.pcbBotaoCadastros);
            this.Controls.Add(this.pcbBotaoSair);
            this.Controls.Add(this.pcbBotaoPesquisar);
            this.Controls.Add(this.pcbBotaoNotasFrequências);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.pcbLogoSchoolSys);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTelaMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoNotasFrequências)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolaFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogoSchoolSys;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.PictureBox pcbBotaoCadastros;
        private System.Windows.Forms.PictureBox pcbBotaoSair;
        private System.Windows.Forms.PictureBox pcbBotaoPesquisar;
        private System.Windows.Forms.PictureBox pcbBotaoNotasFrequências;
        private System.Windows.Forms.PictureBox pcbBolaFoto;
        private System.Windows.Forms.Label lblNomeLogado;
    }
}