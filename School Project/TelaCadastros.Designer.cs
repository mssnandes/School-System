namespace School_Project
{
    partial class frmTelaCadastros
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
            this.lblCadastros = new System.Windows.Forms.Label();
            this.lblQualCadastroDesejaRealizar = new System.Windows.Forms.Label();
            this.pcbBotaoCadastrosAcessos = new System.Windows.Forms.PictureBox();
            this.pcbBotaoCadastrosAlunos = new System.Windows.Forms.PictureBox();
            this.pcbBotaoVoltar = new System.Windows.Forms.PictureBox();
            this.pcbLogoSchoolSys = new System.Windows.Forms.PictureBox();
            this.pcbBolaFoto = new System.Windows.Forms.PictureBox();
            this.lblNomeLogado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastrosAcessos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastrosAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolaFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastros
            // 
            this.lblCadastros.AutoSize = true;
            this.lblCadastros.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastros.ForeColor = System.Drawing.Color.White;
            this.lblCadastros.Location = new System.Drawing.Point(210, 17);
            this.lblCadastros.Name = "lblCadastros";
            this.lblCadastros.Size = new System.Drawing.Size(176, 38);
            this.lblCadastros.TabIndex = 33;
            this.lblCadastros.Text = "Cadastros";
            this.lblCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQualCadastroDesejaRealizar
            // 
            this.lblQualCadastroDesejaRealizar.AutoSize = true;
            this.lblQualCadastroDesejaRealizar.BackColor = System.Drawing.Color.Transparent;
            this.lblQualCadastroDesejaRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualCadastroDesejaRealizar.ForeColor = System.Drawing.Color.White;
            this.lblQualCadastroDesejaRealizar.Location = new System.Drawing.Point(210, 52);
            this.lblQualCadastroDesejaRealizar.Name = "lblQualCadastroDesejaRealizar";
            this.lblQualCadastroDesejaRealizar.Size = new System.Drawing.Size(381, 31);
            this.lblQualCadastroDesejaRealizar.TabIndex = 34;
            this.lblQualCadastroDesejaRealizar.Text = "Qual cadastro deseja realizar?";
            this.lblQualCadastroDesejaRealizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbBotaoCadastrosAcessos
            // 
            this.pcbBotaoCadastrosAcessos.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoCadastrosAcessos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoCadastrosAcessos.Image = global::School_Project.Properties.Resources.Ícone_Cadastros_de_Acessos_Aceso;
            this.pcbBotaoCadastrosAcessos.Location = new System.Drawing.Point(38, 195);
            this.pcbBotaoCadastrosAcessos.Name = "pcbBotaoCadastrosAcessos";
            this.pcbBotaoCadastrosAcessos.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoCadastrosAcessos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoCadastrosAcessos.TabIndex = 35;
            this.pcbBotaoCadastrosAcessos.TabStop = false;
            this.pcbBotaoCadastrosAcessos.Click += new System.EventHandler(this.pcbBotãoCadastrosDeAcessos_Click);
            // 
            // pcbBotaoCadastrosAlunos
            // 
            this.pcbBotaoCadastrosAlunos.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoCadastrosAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoCadastrosAlunos.Image = global::School_Project.Properties.Resources.Ícone_Cadastros_de_Alunos_Aceso;
            this.pcbBotaoCadastrosAlunos.Location = new System.Drawing.Point(38, 255);
            this.pcbBotaoCadastrosAlunos.Name = "pcbBotaoCadastrosAlunos";
            this.pcbBotaoCadastrosAlunos.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoCadastrosAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBotaoCadastrosAlunos.TabIndex = 36;
            this.pcbBotaoCadastrosAlunos.TabStop = false;
            this.pcbBotaoCadastrosAlunos.Click += new System.EventHandler(this.pcbBotãoCadastrosDeAlunos_Click);
            // 
            // pcbBotaoVoltar
            // 
            this.pcbBotaoVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pcbBotaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbBotaoVoltar.Image = global::School_Project.Properties.Resources.Ícone_Voltar_Aceso1;
            this.pcbBotaoVoltar.Location = new System.Drawing.Point(38, 315);
            this.pcbBotaoVoltar.Name = "pcbBotaoVoltar";
            this.pcbBotaoVoltar.Size = new System.Drawing.Size(110, 35);
            this.pcbBotaoVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBotaoVoltar.TabIndex = 37;
            this.pcbBotaoVoltar.TabStop = false;
            this.pcbBotaoVoltar.Click += new System.EventHandler(this.pcbBotãoVoltar_Click);
            // 
            // pcbLogoSchoolSys
            // 
            this.pcbLogoSchoolSys.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogoSchoolSys.Image = global::School_Project.Properties.Resources.Logo_SchooSys_21;
            this.pcbLogoSchoolSys.Location = new System.Drawing.Point(4, -2);
            this.pcbLogoSchoolSys.Name = "pcbLogoSchoolSys";
            this.pcbLogoSchoolSys.Size = new System.Drawing.Size(64, 64);
            this.pcbLogoSchoolSys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoSchoolSys.TabIndex = 38;
            this.pcbLogoSchoolSys.TabStop = false;
            // 
            // pcbBolaFoto
            // 
            this.pcbBolaFoto.BackColor = System.Drawing.Color.Transparent;
            this.pcbBolaFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbBolaFoto.Image = global::School_Project.Properties.Resources.Bola_de_Foto;
            this.pcbBolaFoto.Location = new System.Drawing.Point(45, 66);
            this.pcbBolaFoto.Name = "pcbBolaFoto";
            this.pcbBolaFoto.Size = new System.Drawing.Size(95, 93);
            this.pcbBolaFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBolaFoto.TabIndex = 99;
            this.pcbBolaFoto.TabStop = false;
            // 
            // lblNomeLogado
            // 
            this.lblNomeLogado.AutoSize = true;
            this.lblNomeLogado.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLogado.ForeColor = System.Drawing.Color.White;
            this.lblNomeLogado.Location = new System.Drawing.Point(68, 167);
            this.lblNomeLogado.Name = "lblNomeLogado";
            this.lblNomeLogado.Size = new System.Drawing.Size(41, 15);
            this.lblNomeLogado.TabIndex = 100;
            this.lblNomeLogado.Text = "Nome";
            this.lblNomeLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTelaCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Project.Properties.Resources.Tela_de_Menu1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeLogado);
            this.Controls.Add(this.pcbBolaFoto);
            this.Controls.Add(this.pcbLogoSchoolSys);
            this.Controls.Add(this.pcbBotaoVoltar);
            this.Controls.Add(this.pcbBotaoCadastrosAlunos);
            this.Controls.Add(this.pcbBotaoCadastrosAcessos);
            this.Controls.Add(this.lblQualCadastroDesejaRealizar);
            this.Controls.Add(this.lblCadastros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastros";
            this.Load += new System.EventHandler(this.frmTelaCadastros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastrosAcessos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoCadastrosAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBotaoVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoSchoolSys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolaFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastros;
        private System.Windows.Forms.Label lblQualCadastroDesejaRealizar;
        private System.Windows.Forms.PictureBox pcbBotaoCadastrosAcessos;
        private System.Windows.Forms.PictureBox pcbBotaoCadastrosAlunos;
        private System.Windows.Forms.PictureBox pcbBotaoVoltar;
        private System.Windows.Forms.PictureBox pcbLogoSchoolSys;
        private System.Windows.Forms.PictureBox pcbBolaFoto;
        private System.Windows.Forms.Label lblNomeLogado;
    }
}