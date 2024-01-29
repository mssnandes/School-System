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

namespace School_Project
{
    public partial class frmTelaDeLogin : Form
    {
        private Alunos aluno;

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

        public frmTelaDeLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void telaDeLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(2, 53, 53);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM prj.loginUser
                   WHERE nomeUsuario = @usuario 
                   AND senhaUsuario = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Alunos.NomeUsuario = txtUsuario.Text;

                    frmTelaMenu menu = new frmTelaMenu();
                    Visible = false;
                    menu.ShowDialog();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                    return;
                }

                MessageBox.Show("Usuário e/ou senha inválidos!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '•')
            {
                btnOcultarSenha.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '•';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pcbEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM prj.loginUser
                   WHERE nomeUsuario = @usuario 
                   AND senhaUsuario = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Alunos.NomeUsuario = txtUsuario.Text;

                    frmTelaMenu menu = new frmTelaMenu();
                    Visible = false;
                    menu.ShowDialog();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                    return; 
                }

                MessageBox.Show("Usuário e/ou senha inválidos!");

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }


        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
