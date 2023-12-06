namespace School_Project
{
    partial class telaDeLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.barraEntrar = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Label();
            this.logoSchoolSys = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnMostarSenha = new System.Windows.Forms.Button();
            this.btnOcultarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barraEntrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSchoolSys)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.txtLogin.Location = new System.Drawing.Point(47, 199);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(241, 23);
            this.txtLogin.TabIndex = 0;
            // 
            // barraEntrar
            // 
            this.barraEntrar.BackColor = System.Drawing.Color.Transparent;
            this.barraEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barraEntrar.Image = global::School_Project.Properties.Resources.Botão_Entrar;
            this.barraEntrar.Location = new System.Drawing.Point(32, 339);
            this.barraEntrar.Name = "barraEntrar";
            this.barraEntrar.Size = new System.Drawing.Size(270, 42);
            this.barraEntrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barraEntrar.TabIndex = 9;
            this.barraEntrar.TabStop = false;
            this.barraEntrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(141, 348);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(56, 21);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "entrar";
            this.btnEntrar.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // logoSchoolSys
            // 
            this.logoSchoolSys.BackColor = System.Drawing.Color.Transparent;
            this.logoSchoolSys.Image = global::School_Project.Properties.Resources.Logo_SchooSys_21;
            this.logoSchoolSys.Location = new System.Drawing.Point(4, -2);
            this.logoSchoolSys.Name = "logoSchoolSys";
            this.logoSchoolSys.Size = new System.Drawing.Size(64, 64);
            this.logoSchoolSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoSchoolSys.TabIndex = 12;
            this.logoSchoolSys.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Ubuntu", 14.25F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSenha.Location = new System.Drawing.Point(46, 270);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(215, 23);
            this.txtSenha.TabIndex = 1;
            // 
            // btnMostarSenha
            // 
            this.btnMostarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnMostarSenha.FlatAppearance.BorderSize = 0;
            this.btnMostarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btnMostarSenha.Image = global::School_Project.Properties.Resources.Botão_Mostrar_Senha_Pequeno_com_Cor;
            this.btnMostarSenha.Location = new System.Drawing.Point(257, 270);
            this.btnMostarSenha.Name = "btnMostarSenha";
            this.btnMostarSenha.Size = new System.Drawing.Size(34, 26);
            this.btnMostarSenha.TabIndex = 17;
            this.btnMostarSenha.UseVisualStyleBackColor = false;
            this.btnMostarSenha.Click += new System.EventHandler(this.btnMostarSenha_Click);
            // 
            // btnOcultarSenha
            // 
            this.btnOcultarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnOcultarSenha.FlatAppearance.BorderSize = 0;
            this.btnOcultarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.btnOcultarSenha.Image = global::School_Project.Properties.Resources.Botão_Ocultar_Senha_Pequeno_com_Cor;
            this.btnOcultarSenha.Location = new System.Drawing.Point(257, 269);
            this.btnOcultarSenha.Name = "btnOcultarSenha";
            this.btnOcultarSenha.Size = new System.Drawing.Size(34, 27);
            this.btnOcultarSenha.TabIndex = 18;
            this.btnOcultarSenha.UseVisualStyleBackColor = false;
            this.btnOcultarSenha.Click += new System.EventHandler(this.btnOcultarSenha_Click);
            // 
            // telaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Project.Properties.Resources.Background_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.logoSchoolSys);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.barraEntrar);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnOcultarSenha);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaDeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.telaDeLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barraEntrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoSchoolSys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox barraEntrar;
        private System.Windows.Forms.Label btnEntrar;
        private System.Windows.Forms.PictureBox logoSchoolSys;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnMostarSenha;
        private System.Windows.Forms.Button btnOcultarSenha;
    }
}

