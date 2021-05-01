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
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.String1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.coding;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.coding2;
        }
    }
}
