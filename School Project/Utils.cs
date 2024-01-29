using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public static class Utils
    {
        public static void LimparCampos(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                LimparControle(c);
                if (c.HasChildren)
                {
                    LimparCampos(c);
                }
            }

            void LimparControle(Control c)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is ListBox)
                {
                    ((ListBox)c).Items.Clear();
                }
            }
        }

    }
}
