namespace School_Project
{
    partial class frmTelaDeLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBotaoEntrar = new System.Windows.Forms.Label();
            this.pcbLogoSchoolSys = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnMostarSenha = new System.Windows.Forms.PictureBox();
            this.btnOcultarSenha = new System.Windows.Forms.PictureBox();
            this.pcbBarraUsuario = new System.Windows.Forms.PictureBox();
            this.pcbBarraBotaoEntrar = new System.Windows.Forms.PictureBox();
            this.pcbBarraSenha = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pcbBotaoSair = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblOla = new System.Windows.Forms.Label();
            this.lblFacaLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraBotaoEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBotaoEntrar
            // 
            this.lblBotaoEntrar.AutoSize = true;
            this.lblBotaoEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.lblBotaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBotaoEntrar.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Bold);
            this.lblBotaoEntrar.ForeColor = System.Drawing.Color.White;
            this.lblBotaoEntrar.Location = new System.Drawing.Point(163, 339);
            this.lblBotaoEntrar.Name = "lblBotaoEntrar";
            this.lblBotaoEntrar.Size = new System.Drawing.Size(44, 16);
            this.lblBotaoEntrar.TabIndex = 2;
            this.lblBotaoEntrar.Text = "entrar";
            this.lblBotaoEntrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pcbLogoSchoolSys
            // 
            this.pcbLogoSchoolSys.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogoSchoolSys.Image = global::School_Project.Properties.Resources.Logo_SchooSys_21;
            this.pcbLogoSchoolSys.Location = new System.Drawing.Point(4, -2);
            this.pcbLogoSchoolSys.Name = "pcbLogoSchoolSys";
            this.pcbLogoSchoolSys.Size = new System.Drawing.Size(64, 64);
            this.pcbLogoSchoolSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoSchoolSys.TabIndex = 12;
            this.pcbLogoSchoolSys.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Ubuntu", 8.999999F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSenha.Location = new System.Drawing.Point(96, 275);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(174, 23);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMostarSenha
            // 
            this.btnMostarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnMostarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostarSenha.Image = global::School_Project.Properties.Resources.Botão_Mostrar_Senha_Pequeno_com_Cor1;
            this.btnMostarSenha.Location = new System.Drawing.Point(274, 271);
            this.btnMostarSenha.Name = "btnMostarSenha";
            this.btnMostarSenha.Size = new System.Drawing.Size(34, 27);
            this.btnMostarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMostarSenha.TabIndex = 14;
            this.btnMostarSenha.TabStop = false;
            this.btnMostarSenha.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOcultarSenha
            // 
            this.btnOcultarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOcultarSenha.Image = global::School_Project.Properties.Resources.Botão_Ocultar_Senha_Pequeno_com_Cor2;
            this.btnOcultarSenha.Location = new System.Drawing.Point(274, 271);
            this.btnOcultarSenha.Name = "btnOcultarSenha";
            this.btnOcultarSenha.Size = new System.Drawing.Size(34, 27);
            this.btnOcultarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnOcultarSenha.TabIndex = 15;
            this.btnOcultarSenha.TabStop = false;
            this.btnOcultarSenha.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pcbBarraUsuario
            // 
            this.pcbBarraUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbBarraUsuario.Image = global::School_Project.Properties.Resources.Barra_de_Texto_71;
            this.pcbBarraUsuario.Location = new System.Drawing.Point(52, 197);
            this.pcbBarraUsuario.Name = "pcbBarraUsuario";
            this.pcbBarraUsuario.Size = new System.Drawing.Size(265, 40);
            this.pcbBarraUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBarraUsuario.TabIndex = 83;
            this.pcbBarraUsuario.TabStop = false;
            // 
            // pcbBarraBotaoEntrar
            // 
            this.pcbBarraBotaoEntrar.BackColor = System.Drawing.Color.Transparent;
            this.pcbBarraBotaoEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBarraBotaoEntrar.Image = global::School_Project.Properties.Resources.Barra_de_Texto_6;
            this.pcbBarraBotaoEntrar.Location = new System.Drawing.Point(52, 328);
            this.pcbBarraBotaoEntrar.Name = "pcbBarraBotaoEntrar";
            this.pcbBarraBotaoEntrar.Size = new System.Drawing.Size(265, 40);
            this.pcbBarraBotaoEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBarraBotaoEntrar.TabIndex = 84;
            this.pcbBarraBotaoEntrar.TabStop = false;
            this.pcbBarraBotaoEntrar.Click += new System.EventHandler(this.pcbEntrar_Click);
            // 
            // pcbBarraSenha
            // 
            this.pcbBarraSenha.BackColor = System.Drawing.Color.Transparent;
            this.pcbBarraSenha.Image = global::School_Project.Properties.Resources.Barra_de_Texto_71;
            this.pcbBarraSenha.Location = new System.Drawing.Point(52, 262);
            this.pcbBarraSenha.Name = "pcbBarraSenha";
            this.pcbBarraSenha.Size = new System.Drawing.Size(265, 40);
            this.pcbBarraSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBarraSenha.TabIndex = 85;
            this.pcbBarraSenha.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.Location = new System.Drawing.Point(64, 207);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 23);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pcbBotaoSair
            // 
            this.pcbBotaoSair.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoSair.Image = global::School_Project.Properties.Resources.Botão_Sair_Completamente;
            this.pcbBotaoSair.Location = new System.Drawing.Point(758, 12);
            this.pcbBotaoSair.Name = "pcbBotaoSair";
            this.pcbBotaoSair.Size = new System.Drawing.Size(30, 30);
            this.pcbBotaoSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoSair.TabIndex = 87;
            this.pcbBotaoSair.TabStop = false;
            this.pcbBotaoSair.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Ubuntu Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(52, 177);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 17);
            this.lblUsuario.TabIndex = 95;
            this.lblUsuario.Text = "usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Ubuntu Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(52, 242);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 17);
            this.lblSenha.TabIndex = 96;
            this.lblSenha.Text = "senha";
            // 
            // lblOla
            // 
            this.lblOla.AutoSize = true;
            this.lblOla.BackColor = System.Drawing.Color.Transparent;
            this.lblOla.Font = new System.Drawing.Font("Ubuntu", 24.75F, System.Drawing.FontStyle.Bold);
            this.lblOla.ForeColor = System.Drawing.Color.White;
            this.lblOla.Location = new System.Drawing.Point(143, 68);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(82, 41);
            this.lblOla.TabIndex = 98;
            this.lblOla.Text = "Olá!";
            this.lblOla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFacaLogin
            // 
            this.lblFacaLogin.AutoSize = true;
            this.lblFacaLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblFacaLogin.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacaLogin.ForeColor = System.Drawing.Color.White;
            this.lblFacaLogin.Location = new System.Drawing.Point(121, 109);
            this.lblFacaLogin.Name = "lblFacaLogin";
            this.lblFacaLogin.Size = new System.Drawing.Size(127, 20);
            this.lblFacaLogin.TabIndex = 99;
            this.lblFacaLogin.Text = "Faça o seu Login";
            this.lblFacaLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Project.Properties.Resources.Background_102;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lblFacaLogin);
            this.Controls.Add(this.lblOla);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pcbBotaoSair);
            this.Controls.Add(this.btnMostarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pcbLogoSchoolSys);
            this.Controls.Add(this.lblBotaoEntrar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnOcultarSenha);
            this.Controls.Add(this.pcbBarraUsuario);
            this.Controls.Add(this.pcbBarraBotaoEntrar);
            this.Controls.Add(this.pcbBarraSenha);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.telaDeLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraBotaoEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBarraSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBotaoEntrar;
        private System.Windows.Forms.PictureBox pcbLogoSchoolSys;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.PictureBox btnMostarSenha;
        private System.Windows.Forms.PictureBox btnOcultarSenha;
        private System.Windows.Forms.PictureBox pcbBarraUsuario;
        private System.Windows.Forms.PictureBox pcbBarraBotaoEntrar;
        private System.Windows.Forms.PictureBox pcbBarraSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pcbBotaoSair;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Label lblFacaLogin;
    }
}

