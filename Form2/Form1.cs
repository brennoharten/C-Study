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
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            this.num = 0;
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

        private void btn_show_Click(object sender, EventArgs e)
        {
            F_Lista f_Lista = new F_Lista(tb_list.Text, this);
            f_Lista.ShowDialog();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();

        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }
    }
}
