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
    public partial class F_CheckBox : Form
    {
        public List<CheckBox> atividades = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            atividades.Add(Atividade1);
            atividades.Add(Atividade2);
            atividades.Add(Atividade3);
            atividades.Add(Atividade4);
        }

        private void btn_Atividades_Click(object sender, EventArgs e)
        {
            int num = 0;

            foreach (CheckBox cb in atividades) {
                if (cb.Checked) {
                    num += 1;
                }
            }

            MessageBox.Show(num.ToString());
        }

        private void btn_filho_Click(object sender, EventArgs e)
        {
            F_filhoCheckbox fcb = new F_filhoCheckbox();
            fcb.ShowDialog();
        }
    }
}
