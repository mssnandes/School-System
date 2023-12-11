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
    public partial class cadColaborador : Form
    {
        public cadColaborador()
        {
            InitializeComponent();
            ArredondarPictureBox(picPerfilCol);
        }

        byte[] perfilFoto;


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuAdmin menu = new menuAdmin();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (  txtSenha.Text != txtSenha2.Text  )
            {
                erpPreencherCampos.SetError(txtSenha2, "As senhas não se coincidem");
                return;
            }
            if (  txtSenha.Text.Length > 18)
            {
                erpPreencherCampos.SetError(txtSenha, "A senha deve conter até 18 caracteres");
                return;
            }
            try
            {
                Conexao.Conectar();

                string sql = @"INSERT INTO school.loginUser (nomeUsuario, senhaUsuario, fotoUsuario)
                    VALUES (@nome, @senha, @foto)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("foto", perfilFoto);

                cmd.ExecuteNonQuery();

                Conexao.Fechar();

                MessageBox.Show("Usuário cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void picPerfilCol_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Imagens (*.jpg;*.png;*.jpeg|*.jpg;*.png;*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)

            {

                string caminhoArquivo = openFileDialog.FileName;

                perfilFoto = File.ReadAllBytes(caminhoArquivo);

                picPerfilCol.Image = System.Drawing.Image.FromFile(caminhoArquivo);
            }
        }
    }
}
