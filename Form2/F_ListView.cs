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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void btn_adiconar_Click(object sender, EventArgs e)
        {
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_quantidade.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_Produtos.Items.Add(l);
            clearBox();
        }

        private void clearBox()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_quantidade.Clear();
            tb_preco.Clear();
        }

        private void btn_rm_Click(object sender, EventArgs e)
        {
            lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
        }

        private void lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Produtos.SelectedItems.Count > 0) {
                Obter();
            }
                
        }

        private void Obter()
        {
            tb_id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_quantidade.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
