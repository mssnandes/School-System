using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadAlunos menu = new cadAlunos();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }

        private void consultarNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarNotas menuConsultarNota = new consultarNotas();
            Visible = false;
            menuConsultarNota.ShowDialog();
            Visible = true;
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadColaborador menuColaborador = new cadColaborador();
            Visible = false;
            menuColaborador.ShowDialog();
            Visible = true;
        }
    }
}
