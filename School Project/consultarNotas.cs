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
    public partial class consultarNotas : Form
    {
        public consultarNotas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuUsuario menu = new menuUsuario();
            Visible = false;
            menu.ShowDialog();
            Visible = true;
        }
    }
}
