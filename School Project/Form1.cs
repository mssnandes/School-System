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
    public partial class telaDeLogin : Form
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

        public telaDeLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void telaDeLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(2, 53, 53);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(1, 89, 88);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = @"SELECT * FROM school.loginUser
	                WHERE nomeUsuario = @usuario 
	                AND senhaUsuario = @senha";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                // Verifica se houve retorno de algum registro
                if (dr.HasRows)
                {
                    // Abrir o sistema - LOGIN EFETUADO
                    dr.Read();
                    if (dr["nomeUsuario"].ToString() == "admin")
                    {
                        menuAdmin menu = new menuAdmin();
                        Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                    else if (dr["nomeUsuario"].ToString() != "admin")
                    {
                        menuUsuario menu = new menuUsuario();
                        Visible = false;
                        menu.ShowDialog();
                        Visible = true;
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                }

                Conexao.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMostarSenha_Click(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == '•')
            {
                btnOcultarSenha.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnOcultarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnMostarSenha.BringToFront();
                txtSenha.PasswordChar = '•';
            }
        }
    }
}
