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
    public partial class menuUsuario : Form
    {
        public menuUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarNotas menuConsultarNota = new consultarNotas();
            Visible = false;
            menuConsultarNota.ShowDialog();
            Visible = true;    
        }
    }
}
