using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;

namespace School_Project
{
    public partial class frmTelaCadastrosAlunos : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frmTelaCadastrosAlunos()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void pcbBotãoVoltar_Click(object sender, EventArgs e)
        {
            frmTelaCadastros menu = new frmTelaCadastros();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void ArredondarPictureBox(PictureBox pictureBox)
        {
            // Criar um caminho de gráficos que representa uma elipse (círculo)
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            // Criar uma região com o caminho da elipse
            Region region = new Region(path);

            // Atribuir a região à PictureBox
            pictureBox.Region = region;
        }



        private void frmTelaCadastrosAlunos_Load(object sender, EventArgs e)
        {
            string nomeUsuario = Alunos.NomeUsuario;
            lblNomeLogado.Text = $"{nomeUsuario}";

            lblNomeLogado.Location = new Point((pcbBolaFoto.Left + pcbBolaFoto.Right - lblNomeLogado.Width) / 2, pcbBolaFoto.Bottom + 10);



            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.loginUser WHERE nomeUsuario = @Nome";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                cmd.Parameters.AddWithValue("@Nome", lblNomeLogado.Text);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                    byte[] imagemBytes = (byte[])dt.Rows[0]["fotoUsuario"];

                    if (imagemBytes != null && imagemBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagemBytes))
                        {
                            Image imagem = Image.FromStream(ms);
                            pcbBolaFoto.Image = imagem;
                        }
                    }
                    else
                    {
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBotãoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }

            if (mskCpf.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCpf, "Preencha o campo CPF");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCpf, "");
            }


            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.aluno (alu_nome,alu_cid,alu_nomeresp,alu_bairro,alu_mail,alu_estado,alu_rua,
                    alu_cpf,alu_nasc,alu_cep,alu_n,alu_foneres,alu_cel)
                    VALUES (@nome,@cid,@nomeresp,@bairro,@mail,@estado,@rua,@cpf,@nasc,@cep,
                    @n,@foneres,@cel)";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("cid", txtCidade.Text);
                cmd.Parameters.AddWithValue("nomeresp", txtNomeResponsavel.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("estado", mskEstado.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("cpf", mskCpf.Text);
                cmd.Parameters.AddWithValue("nasc", mskNascimento.Text);
                cmd.Parameters.AddWithValue("cep", mskCep.Text);
                cmd.Parameters.AddWithValue("n", txtNumero.Text);
                cmd.Parameters.AddWithValue("foneres", mskTelefoneResidencial.Text);
                cmd.Parameters.AddWithValue("cel", mskTelefoneCelular.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso!");


                Conexao.Fechar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            mskCpf.SelectionStart = 0;
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            mskNascimento.SelectionStart = 0;

        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            mskCep.SelectionStart = 0;
        }

        private void maskedTextBox5_Click(object sender, EventArgs e)
        {
            mskTelefoneResidencial.SelectionStart = 0;
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            mskTelefoneCelular.SelectionStart = 0;
        }

        private void maskedTextBox6_Click(object sender, EventArgs e)
        {
            mskEstado.SelectionStart = 0;
        }

        private void txtEstado_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            mskEstado.Text = mskEstado.Text.ToUpper();
        }

        private void pcbBarraBotaoCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }

            if (mskCpf.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskCpf, "Preencha o campo CPF");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskCpf, "");
            }


            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.aluno (alu_nome,alu_cid,alu_nomeresp,alu_bairro,alu_mail,alu_estado,alu_rua,
                    alu_cpf,alu_nasc,alu_cep,alu_n,alu_foneres,alu_cel)
                    VALUES (@nome,@cid,@nomeresp,@bairro,@mail,@estado,@rua,@cpf,@nasc,@cep,
                    @n,@foneres,@cel)";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("cid", txtCidade.Text);
                cmd.Parameters.AddWithValue("nomeresp", txtNomeResponsavel.Text);
                cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("estado", mskEstado.Text);
                cmd.Parameters.AddWithValue("rua", txtRua.Text);
                cmd.Parameters.AddWithValue("cpf", mskCpf.Text);
                cmd.Parameters.AddWithValue("nasc", mskNascimento.Text);
                cmd.Parameters.AddWithValue("cep", mskCep.Text);
                cmd.Parameters.AddWithValue("n", txtNumero.Text);
                cmd.Parameters.AddWithValue("foneres", mskTelefoneResidencial.Text);
                cmd.Parameters.AddWithValue("cel", mskTelefoneCelular.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso!");


                Conexao.Fechar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        public void LocalizarCEP()
        {
            using (var ws = new ServiceReference1.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCep.Text);
                    txtCidade.Text = resultado.cidade;
                    mskEstado.Text = resultado.uf;
                    txtRua.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {

        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
    }
}
