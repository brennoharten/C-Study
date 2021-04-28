
namespace Form2
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_text = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_list = new System.Windows.Forms.TextBox();
            this.lb_Principal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(32, 52);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(247, 20);
            this.tb_text.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(285, 50);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(32, 415);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(328, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_list
            // 
            this.tb_list.Location = new System.Drawing.Point(32, 79);
            this.tb_list.Multiline = true;
            this.tb_list.Name = "tb_list";
            this.tb_list.Size = new System.Drawing.Size(328, 289);
            this.tb_list.TabIndex = 3;
            // 
            // lb_Principal
            // 
            this.lb_Principal.AutoSize = true;
            this.lb_Principal.Location = new System.Drawing.Point(32, 33);
            this.lb_Principal.Name = "lb_Principal";
            this.lb_Principal.Size = new System.Drawing.Size(141, 13);
            this.lb_Principal.TabIndex = 4;
            this.lb_Principal.Text = "Adicione um elemento a lista";
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.lb_Principal);
            this.Controls.Add(this.tb_list);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_text);
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_list;
        private System.Windows.Forms.Label lb_Principal;
    }
}

