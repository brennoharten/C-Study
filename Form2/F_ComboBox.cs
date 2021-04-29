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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_Atividades.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_Atividades.Items.Clear();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            List<string> defaultList = new List<string>();

            defaultList.Add("atividade1");
            defaultList.Add("atividade2");
            defaultList.Add("atividade3");
            defaultList.Add("atividade4");

            cb_Atividades.Items.AddRange(defaultList.ToArray());
        }

        private void cb_Atividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_add.Text = cb_Atividades.Text;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!cb_Atividades.Items.Contains(tb_add.Text.Trim()) & (tb_add.Text.Trim() != "")) {
                cb_Atividades.Items.Add(tb_add.Text);
            }

            tb_add.Clear();
            tb_add.Focus();
        }
    }
}
