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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_text.Text == "") {
                MessageBox.Show("adicione um elemento a lista");
                tb_text.Focus();
                return;
            }

            tb_list.Text += tb_text.Text + ", ";
            tb_text.Clear();
            tb_text.Focus();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_list.Clear();
            tb_text.Clear();
            tb_text.Focus();
        }
    }
}
