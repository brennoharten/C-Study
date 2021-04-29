
namespace Form2
{
    partial class F_ListBox
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
            this.lb_main = new System.Windows.Forms.ListBox();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_main
            // 
            this.lb_main.FormattingEnabled = true;
            this.lb_main.Location = new System.Drawing.Point(12, 12);
            this.lb_main.Name = "lb_main";
            this.lb_main.Size = new System.Drawing.Size(125, 251);
            this.lb_main.TabIndex = 0;
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(157, 12);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(183, 20);
            this.tb_text.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(157, 49);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(183, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(157, 78);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(183, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(157, 107);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(183, 23);
            this.btn_get.TabIndex = 4;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 399);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.lb_main);
            this.Name = "F_ListBox";
            this.Text = "F_ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_main;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_get;
    }
}