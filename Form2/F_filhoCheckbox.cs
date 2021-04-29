using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class F_filhoCheckbox : Form
    {
        F_CheckBox fcb;
        public F_filhoCheckbox()
        {
            InitializeComponent();
            fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
            Atividade1.Checked = fcb.Atividade1.Checked;
            Atividade2.Checked = fcb.Atividade2.Checked;
            Atividade3.Checked = fcb.Atividade3.Checked;
            Atividade4.Checked = fcb.Atividade4.Checked;

        }

        private void Atividade1_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Atividade1.Checked = Atividade1.Checked;
        }

        private void Atividade2_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Atividade2.Checked = Atividade2.Checked;
        }

        private void Atividade3_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Atividade3.Checked = Atividade3.Checked;
        }

        private void Atividade4_CheckedChanged(object sender, EventArgs e)
        {
            fcb.Atividade4.Checked = Atividade4.Checked;
        }
    }
}
