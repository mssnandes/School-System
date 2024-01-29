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
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;

namespace School_Project
{
    public partial class frmTelaCadastrosAcessos : Form
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
    
        public frmTelaCadastrosAcessos()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFotoCadastroAcessos);
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        byte[] perfilFoto;

        private void pcbBotãoVoltar_Click(object sender, EventArgs e)
        {
            frmTelaCadastros menu = new frmTelaCadastros();
            Visible = false;
            menu.ShowDialog();
            Visible = true;

        }

        private void frmTelaCadastrosAcessos_Load(object sender, EventArgs e)
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

        private void pcbBolaFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Imagens (*.jpg;*.png;*.jpeg|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                string caminhoArquivo = openFileDialog.FileName;

                perfilFoto = File.ReadAllBytes(caminhoArquivo);

                pcbBolaFotoCadastroAcessos.Image = System.Drawing.Image.FromFile(caminhoArquivo);
            }
        }

        private void pcbBarraBotaoCadastrar_Click(object sender, EventArgs e)
        {

            if (txtSenha.Text != txtRedigiteSenha.Text)
            {
                erpPreencherCampos.SetError(txtRedigiteSenha, "As senhas não se coincidem");
                return;
            }
            if (txtSenha.Text.Length > 18)
            {
                erpPreencherCampos.SetError(txtSenha, "A senha deve conter até 18 caracteres");
                return;
            }
            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.loginUser (nomeUsuario, senhaUsuario, fotoUsuario)
                VALUES (@nome, @senha, @foto)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                byte[] imagemBytes = null;
                if (pcbBolaFotoCadastroAcessos.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbBolaFotoCadastroAcessos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // ou o formato desejado
                        imagemBytes = ms.ToArray();
                    }
                }

                // Adiciona o valor do array de bytes ao parâmetro
                SqlParameter fotoParam = new SqlParameter("@foto", SqlDbType.Image);
                fotoParam.Value = (object)imagemBytes ?? DBNull.Value;
                cmd.Parameters.Add(fotoParam);

                cmd.ExecuteNonQuery();

                Conexao.Fechar();

                MessageBox.Show("Usuário cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }

        private void lblBotaoCadastrar_Click(object sender, EventArgs e)
        {


            if (txtSenha.Text != txtRedigiteSenha.Text)
            {
                erpPreencherCampos.SetError(txtRedigiteSenha, "As senhas não se coincidem");
                return;
            }
            if (txtSenha.Text.Length > 18)
            {
                erpPreencherCampos.SetError(txtSenha, "A senha deve conter até 18 caracteres");
                return;
            }
            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO prj.loginUser (nomeUsuario, senhaUsuario, fotoUsuario)
                VALUES (@nome, @senha, @foto)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                byte[] imagemBytes = null;
                if (pcbBolaFotoCadastroAcessos.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pcbBolaFotoCadastroAcessos.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // ou o formato desejado
                        imagemBytes = ms.ToArray();
                    }
                }

                // Adiciona o valor do array de bytes ao parâmetro
                SqlParameter fotoParam = new SqlParameter("@foto", SqlDbType.Image);
                fotoParam.Value = (object)imagemBytes ?? DBNull.Value;
                cmd.Parameters.Add(fotoParam);

                cmd.ExecuteNonQuery();

                Conexao.Fechar();

                MessageBox.Show("Usuário cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            Utils.LimparCampos(this);
        }
    }
}
