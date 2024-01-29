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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;

namespace School_Project
{
    public partial class frmTelaNotasFrequências : Form
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

        public frmTelaNotasFrequências()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pcbBotãoVoltar_Click(object sender, EventArgs e)
        {
            frmTelaMenu menu = new frmTelaMenu();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            msk1Bimestre.SelectionStart = 0;
        }

        private void maskedTextBox2_Click(object sender, EventArgs e)
        {
            msk2Bimestre.SelectionStart = 0;
        }

        private void maskedTextBox3_Click(object sender, EventArgs e)
        {
            msk3Bimestre.SelectionStart = 0;
        }

        private void maskedTextBox4_Click(object sender, EventArgs e)
        {
            msk4Bimestre.SelectionStart = 0;
        }

        private void mskCep_Click(object sender, EventArgs e)
        {
            mskMatricula.SelectionStart = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void TelaNotasFrequências_Load(object sender, EventArgs e)
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

        private void pcbBarraBotaoCalcularMedia_Click(object sender, EventArgs e)
        {
            double total;

            total = (double.Parse(msk1Bimestre.Text) + double.Parse(msk2Bimestre.Text) + double.Parse(msk3Bimestre.Text) + double.Parse(msk4Bimestre.Text)) / 40;

            txtMediaFinal.Text = "" + total;
        }

        private void lblBotaoCalcularMedia_Click(object sender, EventArgs e)
        {
            double total;

            total = (double.Parse(msk1Bimestre.Text) + double.Parse(msk2Bimestre.Text) + double.Parse(msk3Bimestre.Text) + double.Parse(msk4Bimestre.Text)) / 40;

            txtMediaFinal.Text = "" + total;
        }

        private void pcbBarraBotaoCadastrar_Click(object sender, EventArgs e)
        {
            if (mskMatricula.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskMatricula, "Preencha o campo matricula");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskMatricula, "");
            }

            if (txtFrequencia.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtFrequencia, "Preencha o campo frequência");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(txtFrequencia, "");
            }



            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.caderneta (cad_alu , cad_mat ,cad_freq ,cad_media)
                VALUES (@alu, @mat, @freq, @media)";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("alu", int.Parse(mskMatricula.Text));
                cmd.Parameters.AddWithValue("mat", int.Parse(cbbMateria.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("freq", txtFrequencia.Text);
                cmd.Parameters.AddWithValue("media", txtMediaFinal.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Notas do Alunos cadastradas com sucesso!");


                Conexao.Fechar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void mskMatricula_Leave(object sender, EventArgs e)
        {

        }

        private void lblBotaoCadastrar_Click(object sender, EventArgs e)
        {
            if (mskMatricula.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(mskMatricula, "Preencha o campo matricula");
                return;
            }
            else
            {
                erpPreencherCampos.SetError(mskMatricula, "");
            }


            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.caderneta (cad_alu , cad_mat ,cad_freq ,cad_media)
                VALUES (@alu, @mat, @freq, @media)";

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("alu", int.Parse(mskMatricula.Text));
                cmd.Parameters.AddWithValue("mat", int.Parse(cbbMateria.SelectedValue?.ToString()));
                cmd.Parameters.AddWithValue("freq", txtFrequencia.Text);
                cmd.Parameters.AddWithValue("media", txtMediaFinal.Text);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Notas do Alunos cadastradas com sucesso!");


                Conexao.Fechar();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


            Utils.LimparCampos(this);
        }

        private void cbbNome_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.aluno WHERE alu_cod = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbNome.SelectedValue?.ToString());
                SqlDataReader matr = cmd.ExecuteReader();
                matr.Read();
                mskMatricula.Text = matr["alu_cod"].ToString();
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
