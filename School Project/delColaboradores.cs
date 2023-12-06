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
    public partial class delColaboradores : Form
    {
        public delColaboradores()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = @"SELECT * FROM LEITORES
                    WHERE NOME LIKE '" + txtPesquisa.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvAlunos.DataSource = dt;
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

        private void delColaboradores_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM alunos";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                // DataTable - Cópia da tabela para memória
                DataTable dt = new DataTable();
                // Carregar o DataTable com os dados da tabela
                dt.Load(cmd.ExecuteReader());
                dgvAlunos.DataSource = dt;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /*DataGridViewRow linha;
            linha = dgvAlunos.CurrentRow;
            Alunos.codigo = linha.Cells["CODIGO"].Value.ToString();
            Alunos.nome = linha.Cells["NOME"].Value.ToString();
            Close();*/
        }
    }
}
