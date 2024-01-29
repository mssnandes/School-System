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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace School_Project
{
    public partial class frmTelaMenu : Form
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

        public frmTelaMenu()
        {
            InitializeComponent();
            ArredondarPictureBox(pcbBolaFoto);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void pcbBotãoSair_Click(object sender, EventArgs e)
        {
            frmTelaDeLogin menu = new frmTelaDeLogin();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void pcbBotãoCadastros_Click(object sender, EventArgs e)
        {
            frmTelaCadastros menu = new frmTelaCadastros();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void frmTelaMenu_Load(object sender, EventArgs e)
        {
            string nomeUsuario = Alunos.NomeUsuario;
            lblAdministrador.Text = $"{nomeUsuario}";
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

 

        private void pcbBotãoNotasFrequências_Click(object sender, EventArgs e)
        {
            frmTelaNotasFrequências menu = new frmTelaNotasFrequências();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void pcbBotãoPesquisar_Click(object sender, EventArgs e)
        {
            frmTelaPesquisa menu = new frmTelaPesquisa();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void pcbBolaFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
