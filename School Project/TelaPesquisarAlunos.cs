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
    public partial class frmTelaPesquisarAlunos : Form
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

        public frmTelaPesquisarAlunos()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pcbBotãoVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPesquisa menu = new frmTelaPesquisa();
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

        public void LocalizarCEP()
        {
            using (var ws = new ServiceReference1.AtendeClienteClient())
            {
                try
                {
                    var resultado = ws.consultaCEP(mskCep.Text);
                    txtCidade.Text = resultado.cidade;
                    txtEstado.Text = resultado.uf;
                    txtRua.Text = resultado.end;
                    txtBairro.Text = resultado.bairro;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void frmTelaPesquisarAlunos_Load(object sender, EventArgs e)
        {
            string nomeUsuario = Alunos.NomeUsuario;
            lblNomeLogado.Text = $"{nomeUsuario}";

            lblNomeLogado.Location = new Point((pcbBolaFoto.Left + pcbBolaFoto.Right - lblNomeLogado.Width) / 2, pcbBolaFoto.Bottom + 10);


            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.aluno";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cbbNome.DataSource = dt;
                cbbNome.DisplayMember = "alu_nome";
                cbbNome.ValueMember = "alu_cod";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }

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

        private void mskCpf_MouseClick(object sender, MouseEventArgs e)
        {
            mskCpf.SelectionStart = 0;
        }

        private void mskNascimento_Click(object sender, EventArgs e)
        {
            mskNascimento.SelectionStart = 0;
        }

        private void mskCep_Click(object sender, EventArgs e)
        {
            mskCep.SelectionStart = 0;
        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.SelectionStart = 0;
        }

        private void mskCelular_Click(object sender, EventArgs e)
        {
            mskCelular.SelectionStart = 0;
        }

        private void pcbBarraBotaoExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM prj.caderneta
                WHERE cad_alu = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }




            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM prj.aluno
                WHERE alu_cod = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro do aluno excluído com sucesso!");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }

            Utils.LimparCampos(this);

        }

        private void cbbMatricula_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.aluno WHERE alu_cod = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                SqlDataReader matr = cmd.ExecuteReader();
                matr.Read();
                txtMatricula.Text = matr["alu_cod"].ToString();
                txtCidade.Text = matr["alu_cid"].ToString();
                txtNomeResp.Text = matr["alu_nomeresp"].ToString();
                txtBairro.Text = matr["alu_bairro"].ToString();
                txtEmail.Text = matr["alu_mail"].ToString();
                txtEstado.Text = matr["alu_estado"].ToString();
                mskCpf.Text = matr["alu_cpf"].ToString();
                mskNascimento.Text = matr["alu_nasc"].ToString();
                mskCep.Text = matr["alu_cep"].ToString();
                txtNumero.Text = matr["alu_n"].ToString();
                mskTelefone.Text = matr["alu_foneres"].ToString();
                mskCelular.Text = matr["alu_cel"].ToString();
                txtRua.Text = matr["alu_rua"].ToString();
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

        private void lblBotaoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM prj.aluno
                WHERE alu_cod = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro do aluno excluído com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Fechar();
            }

            Utils.LimparCampos(this);
        }

        private void pcbBarraBotaoAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE prj.aluno SET 
                alu_cid = @CIDADE,
                alu_nomeresp = @NOMERESP,
                alu_bairro = @BAIRRO,
                alu_mail = @EMAIL,
                alu_estado = @ESTADO,
                alu_rua = @RUA,
                alu_cpf = @CPF,
                alu_nasc = @NASC,
                alu_cep = @CEP,
                alu_n = @N,
                alu_foneres = @FONERESP,
                alu_cel = @CEL
                WHERE alu_cod = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CODIGO", cbbNome.SelectedValue?.ToString());
                cmd.Parameters.AddWithValue("CIDADE", txtCidade.Text);
                cmd.Parameters.AddWithValue("NOMERESP", txtNomeResp.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("ESTADO", txtEstado.Text);
                cmd.Parameters.AddWithValue("RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("CPF", mskCpf.Text);
                cmd.Parameters.AddWithValue("NASC", mskNascimento.Text);
                cmd.Parameters.AddWithValue("CEP", mskCep.Text);
                cmd.Parameters.AddWithValue("N", txtNumero.Text);
                cmd.Parameters.AddWithValue("FONERESP", mskTelefone.Text);
                cmd.Parameters.AddWithValue("CEL", mskCelular.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro do aluno Alterado Com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar aluno: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void lblBotaoAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE prj.aluno SET
                alu_cid = @CIDADE,
                alu_nomeresp = @NOMERESP,
                alu_bairro = @BAIRRO,
                alu_mail = @EMAIL,
                alu_estado = @ESTADO,
                alu_rua = @RUA,
                alu_cpf = @CPF,
                alu_nasc = @NASC,
                alu_cep = @CEP,
                alu_n = @N,
                alu_foneres = @FONERESP,
                alu_cel = @CEL
                WHERE alu_cod = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CODIGO", cbbNome.SelectedValue?.ToString());
                cmd.Parameters.AddWithValue("CIDADE", txtCidade.Text);
                cmd.Parameters.AddWithValue("NOMERESP", txtNomeResp.Text);
                cmd.Parameters.AddWithValue("BAIRRO", txtBairro.Text);
                cmd.Parameters.AddWithValue("EMAIL", txtEmail.Text);
                cmd.Parameters.AddWithValue("ESTADO", txtEstado.Text);
                cmd.Parameters.AddWithValue("RUA", txtRua.Text);
                cmd.Parameters.AddWithValue("CPF", mskCpf.Text);
                cmd.Parameters.AddWithValue("NASC", mskNascimento.Text);
                cmd.Parameters.AddWithValue("CEP", mskCep.Text);
                cmd.Parameters.AddWithValue("N", txtNumero.Text);
                cmd.Parameters.AddWithValue("FONERESP", mskTelefone.Text);
                cmd.Parameters.AddWithValue("CEL", mskCelular.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro do aluno Alterado Com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar aluno: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
    }
}
