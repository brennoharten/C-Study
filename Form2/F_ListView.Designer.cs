
namespace Form2
{
    partial class F_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "teclado",
            "80",
            "39,99"}, -1);
            this.lv_Produtos = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adiconar = new System.Windows.Forms.Button();
            this.btn_rm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Produtos
            // 
            this.lv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Produto,
            this.col_qtde,
            this.col_Preco});
            this.lv_Produtos.FullRowSelect = true;
            this.lv_Produtos.HideSelection = false;
            this.lv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lv_Produtos.Location = new System.Drawing.Point(21, 23);
            this.lv_Produtos.Name = "lv_Produtos";
            this.lv_Produtos.Size = new System.Drawing.Size(633, 201);
            this.lv_Produtos.TabIndex = 0;
            this.lv_Produtos.UseCompatibleStateImageBehavior = false;
            this.lv_Produtos.View = System.Windows.Forms.View.Details;
            this.lv_Produtos.SelectedIndexChanged += new System.EventHandler(this.lv_Produtos_SelectedIndexChanged);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 40;
            // 
            // col_Produto
            // 
            this.col_Produto.Text = "Produto";
            this.col_Produto.Width = 360;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quatidade";
            this.col_qtde.Width = 80;
            // 
            // col_Preco
            // 
            this.col_Preco.Text = "Preço";
            this.col_Preco.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(24, 283);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(60, 20);
            this.tb_id.TabIndex = 2;
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(90, 282);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(161, 20);
            this.tb_produto.TabIndex = 3;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(257, 282);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(69, 20);
            this.tb_quantidade.TabIndex = 4;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(332, 282);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(100, 20);
            this.tb_preco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preco";
            // 
            // btn_adiconar
            // 
            this.btn_adiconar.Location = new System.Drawing.Point(24, 328);
            this.btn_adiconar.Name = "btn_adiconar";
            this.btn_adiconar.Size = new System.Drawing.Size(75, 23);
            this.btn_adiconar.TabIndex = 9;
            this.btn_adiconar.Text = "button1";
            this.btn_adiconar.UseVisualStyleBackColor = true;
            this.btn_adiconar.Click += new System.EventHandler(this.btn_adiconar_Click);
            // 
            // btn_rm
            // 
            this.btn_rm.Location = new System.Drawing.Point(24, 357);
            this.btn_rm.Name = "btn_rm";
            this.btn_rm.Size = new System.Drawing.Size(75, 23);
            this.btn_rm.TabIndex = 10;
            this.btn_rm.Text = "button2";
            this.btn_rm.UseVisualStyleBackColor = true;
            this.btn_rm.Click += new System.EventHandler(this.btn_rm_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btn_rm);
            this.Controls.Add(this.btn_adiconar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Produtos);
            this.Name = "F_ListView";
            this.Text = "F_ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Produtos;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_Preco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adiconar;
        private System.Windows.Forms.Button btn_rm;
    }
}