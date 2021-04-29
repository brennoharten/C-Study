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
    public partial class F_Lista : Form
    {
        F_Principal fp;
        public F_Lista(string v, F_Principal f)
        {
            InitializeComponent();
            tb_lista.Text = v;
            fp = f;
            f.num = 10;
        }

        private void F_Lista_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_list.Text = tb_lista.Text;
        }
    }
}
