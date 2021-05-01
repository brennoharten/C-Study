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
            linkLabel3.Links.Add(0, 7, "www.youtube.com.br");
            linkLabel3.Links.Add(10, 18, "www.instagram.com.br");
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

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void maskedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }
        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com/search?q=" + tb_text.Text);
            
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_Picture = new F_PictureBox();
            f_Picture.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            switch (e.ClickedItem.Name.ToString()) {
                case "tsmi_fechar":
                    this.Close();
                    break;
                case "tsmi_resetar":
                    this.WindowState = FormWindowState.Normal;
                    break;
            
            }
        }
    }
}
