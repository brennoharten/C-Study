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
    public partial class F_ListBox : Form
    {
        List<string> lista = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();
            lista.Add("Atividade1");
            lista.Add("Atividade2");
            lista.Add("Atividade3");
            lista.Add("Atividade4");

            lb_main.DataSource = this.lista; //isso pode ser um banco de dados, nesse caso estou usando uma lista simples

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_text.Text.Trim() != "")
            {
                this.lista.Add(tb_text.Text);
                tb_text.Clear();
                atualizarLista(lb_main, this.lista);
            }
            else {
                MessageBox.Show("adicio algo a lista");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(lb_main.SelectedIndex);
            atualizarLista(lb_main, this.lista);
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            tb_text.Text = lista[lb_main.SelectedIndex];

        }

        private void atualizarLista(ListBox lb, List<string> lista) {
            lb.DataSource = null;
            lb.DataSource = lista;
        }
    }
}
