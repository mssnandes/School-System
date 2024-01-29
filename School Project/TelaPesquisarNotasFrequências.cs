using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class frmTelaPesquisarNotasFrequencias : Form
    {
        public frmTelaPesquisarNotasFrequencias()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
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

        private void frmTelaPesquisarNotasFrequencias_Load(object sender, EventArgs e)
        {
            string nomeUsuario = Alunos.NomeUsuario;
            lblNomeLogado.Text = $"{nomeUsuario}";

            lblNomeLogado.Location = new Point((pcbBolaFoto.Left + pcbBolaFoto.Right - lblNomeLogado.Width) / 2, pcbBolaFoto.Bottom + 10);


            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.materias";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt1 = new DataTable();
                dt1.Load(cmd.ExecuteReader());
                cbbMateria.DataSource = dt1;
                cbbMateria.DisplayMember = "mat_nome";
                cbbMateria.ValueMember = "mat_id";
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

        private void pcbBarraBotaoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM prj.caderneta
                WHERE cad_alu = @codigo AND cad_mat = @codigomat";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.Parameters.AddWithValue("codigomat", cbbMateria.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nota excluída com sucesso!");


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

        private void lblBotaoExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"DELETE FROM prj.caderneta
                WHERE cad_alu = @codigo AND cad_mat = @codigomat";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.Parameters.AddWithValue("codigomat", cbbMateria.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nota excluída com sucesso!");


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

            if (cbbNome.SelectedItem == null)
            {
                erpPreencherCampos.SetError(cbbNome, "Selecione um item na ComboBox");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cbbNome, "");
            }

            if (cbbMateria.SelectedItem == null)
            {
                erpPreencherCampos.SetError(cbbMateria, "Selecione um item na ComboBox");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cbbMateria, "");
            }


            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE prj.caderneta SET
                cad_freq = @freq,
                cad_media = @media
                WHERE cad_alu = @CODIGO  AND cad_mat = @mat";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CODIGO", int.Parse(cbbNome.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("mat", int.Parse(cbbMateria.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("freq", txtFrequencia.Text);
                cmd.Parameters.AddWithValue("media", txtMediaFinal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Nota Alterada Com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar aluno: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void lblBotaoAlterar_Click(object sender, EventArgs e)
        {
            if (cbbNome.SelectedItem == null)
            {
                erpPreencherCampos.SetError(cbbNome, "Selecione um item na ComboBox");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cbbNome, "");
            }

            if (cbbMateria.SelectedItem == null)
            {
                erpPreencherCampos.SetError(cbbMateria, "Selecione um item na ComboBox");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(cbbMateria, "");
            }


            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE prj.caderneta SET
                cad_freq = @freq,
                cad_media = @media
                WHERE cad_alu = @CODIGO  AND cad_mat = @mat";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("CODIGO", int.Parse(cbbNome.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("mat", int.Parse(cbbMateria.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("freq", txtFrequencia.Text);
                cmd.Parameters.AddWithValue("media", txtMediaFinal.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Nota Alterada Com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar aluno: " + ex.Message);
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

        private void pcbBarraBotaoRecalcular_Click(object sender, EventArgs e)
        {
            double total;

            total = (double.Parse(txt1Bimestre.Text) + double.Parse(txt2Bimestre.Text) + double.Parse(txt3Bimestre.Text) + double.Parse(txt4Bimestre.Text)) / 4;

            txtMediaFinal.Text = "" + total;
        }

        private void lblBotaoRecalcular_Click(object sender, EventArgs e)
        {
            double total;

            total = (double.Parse(txt1Bimestre.Text) + double.Parse(txt2Bimestre.Text) + double.Parse(txt3Bimestre.Text) + double.Parse(txt4Bimestre.Text)) / 4;

            txtMediaFinal.Text = "" + total;
        }

        private void pcbBotaoVoltar_Click(object sender, EventArgs e)
        {
            frmTelaPesquisa menu = new frmTelaPesquisa();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void cbbMateria_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.caderneta WHERE cad_alu = @codigo AND cad_mat = @mat";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                cmd.Parameters.AddWithValue("mat", int.Parse(cbbMateria.SelectedValue?.ToString()));
                SqlDataReader matr = cmd.ExecuteReader();
                matr.Read();
                txtMediaFinal.Text = matr["cad_media"].ToString();
                txtFrequencia.Text = matr["cad_freq"].ToString();
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
    }
}
