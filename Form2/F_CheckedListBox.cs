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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_num_Click(object sender, EventArgs e)
        {
            int num = 0;
            num = clb_tasks.CheckedItems.Count;
            MessageBox.Show(num.ToString());
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clb_tasks.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clb_tasks.Items.Clear();

            List<String> tr = new List<string>();
            tr.Add("atividade1");
            tr.Add("atividade2");
            tr.Add("atividade3");
            tr.Add("atividade4");

            clb_tasks.Items.AddRange(tr.ToArray());
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_add.Text.Trim() != "") {
                clb_tasks.Items.Add(tb_add.Text);
            }
            tb_add.Clear();
            tb_add.Focus();

        }
    }
}
