using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

                string sql = @"INSERT INTO school.loginUser (nomeUsuario, senhaUsuario)
                    VALUES (@nome, @senha)";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("nome", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                cmd.ExecuteNonQuery();

                Conexao.Fechar();

                MessageBox.Show("Usuário cadastrado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
