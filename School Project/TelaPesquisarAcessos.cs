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
    public partial class frmTelaPesquisarAcessos : Form
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

        public frmTelaPesquisarAcessos()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        byte[] perfilFoto;

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

        private void frmTelaPesquisarAcessos_Load(object sender, EventArgs e)
        {
            string nomeUsuario = Alunos.NomeUsuario;
            lblNomeLogado.Text = $"{nomeUsuario}";

            lblNomeLogado.Location = new Point((pcbBolaFoto.Left + pcbBolaFoto.Right - lblNomeLogado.Width) / 2, pcbBolaFoto.Bottom + 10);

            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.loginUser";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                cbbUsuario.DataSource = dt;
                cbbUsuario.DisplayMember = "nomeUsuario";
                cbbUsuario.ValueMember = "log_cod";
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
                    string sql1 = @"DELETE FROM prj.loginUser
                    WHERE log_cod = @codigo";
                    SqlCommand cmd1 = new SqlCommand(sql1, Conexao.conn);
                    cmd1.Parameters.AddWithValue("codigo", cbbUsuario.SelectedValue?.ToString());
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Acesso excluído com sucesso!");


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
                string sql = @"DELETE FROM prj.loginUser
                WHERE log_cod = @codigo";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("codigo", cbbUsuario.SelectedValue?.ToString());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Acesso excluído com sucesso!");


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
                string sql = @"UPDATE prj.loginUser SET
                   nomeUsuario = COALESCE(@NOME, nomeUsuario), 
                   senhaUsuario = COALESCE(@SENHA, senhaUsuario),
                   fotoUsuario = COALESCE(@foto, fotoUsuario)
                   WHERE log_cod = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("@CODIGO", cbbUsuario.SelectedValue?.ToString());

                if (!string.IsNullOrEmpty(txtAlterarUsuario.Text))
                {
                    cmd.Parameters.AddWithValue("@NOME", txtAlterarUsuario.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(txtAlterarSenha.Text))
                {
                    cmd.Parameters.AddWithValue("@SENHA", txtAlterarSenha.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SENHA", DBNull.Value);
                }

                byte[] imagemBytes = null;
                if (pcbBolaFotoPesquisaAcessos.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbBolaFotoPesquisaAcessos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagemBytes = ms.ToArray();
                    }
                }

                // Adiciona o valor do array de bytes ao parâmetro
                SqlParameter fotoParam = new SqlParameter("@foto", SqlDbType.Image);
                fotoParam.Value = (object)imagemBytes ?? DBNull.Value;
                cmd.Parameters.Add(fotoParam);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Acesso Alterado Com Sucesso!");


            }
            catch (Exception ex)
            {

            }

            Utils.LimparCampos(this);


            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.loginUser WHERE nomeUsuario = @Nome";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                // Substitua "SeuNome" pelo valor desejado ou obtenha-o de um controle TextBox, por exemplo
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
                        MessageBox.Show("Nenhuma foto encontrada para o usuário especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma foto encontrada para o usuário especificado.");
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

        private void lblBotaoAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"UPDATE prj.loginUser SET
                   nomeUsuario = COALESCE(@NOME, nomeUsuario), 
                   senhaUsuario = COALESCE(@SENHA, senhaUsuario),
                   fotoUsuario = COALESCE(@foto, fotoUsuario)
                   WHERE log_cod = @CODIGO";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("@CODIGO", cbbUsuario.SelectedValue?.ToString());

                if (!string.IsNullOrEmpty(txtAlterarUsuario.Text))
                {
                    cmd.Parameters.AddWithValue("@NOME", txtAlterarUsuario.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NOME", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(txtAlterarSenha.Text))
                {
                    cmd.Parameters.AddWithValue("@SENHA", txtAlterarSenha.Text);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@SENHA", DBNull.Value);
                }

                byte[] imagemBytes = null;
                if (pcbBolaFotoPesquisaAcessos.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbBolaFotoPesquisaAcessos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imagemBytes = ms.ToArray();
                    }
                }

                // Adiciona o valor do array de bytes ao parâmetro
                SqlParameter fotoParam = new SqlParameter("@foto", SqlDbType.Image);
                fotoParam.Value = (object)imagemBytes ?? DBNull.Value;
                cmd.Parameters.Add(fotoParam);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Acesso Alterado Com Sucesso!");


            }
            catch (Exception ex)
            {

            }

            Utils.LimparCampos(this);

            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM prj.loginUser WHERE nomeUsuario = @Nome";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                // Substitua "SeuNome" pelo valor desejado ou obtenha-o de um controle TextBox, por exemplo
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
                        MessageBox.Show("Nenhuma foto encontrada para o usuário especificado.");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma foto encontrada para o usuário especificado.");
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

        private void pcbBolaFotoPesquisaAcessos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Imagens (*.jpg;*.png;*.jpeg|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                string caminhoArquivo = openFileDialog.FileName;

                perfilFoto = File.ReadAllBytes(caminhoArquivo);

                pcbBolaFotoPesquisaAcessos.Image = System.Drawing.Image.FromFile(caminhoArquivo);
            }
        }
    }
}
