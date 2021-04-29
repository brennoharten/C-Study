
namespace Form2
{
    partial class F_CheckedListBox
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
            this.clb_tasks = new System.Windows.Forms.CheckedListBox();
            this.btn_num = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_tasks
            // 
            this.clb_tasks.FormattingEnabled = true;
            this.clb_tasks.Items.AddRange(new object[] {
            "atividade1",
            "atividade2",
            "atividade3",
            "atividade4"});
            this.clb_tasks.Location = new System.Drawing.Point(69, 34);
            this.clb_tasks.Name = "clb_tasks";
            this.clb_tasks.Size = new System.Drawing.Size(120, 214);
            this.clb_tasks.TabIndex = 0;
            // 
            // btn_num
            // 
            this.btn_num.Location = new System.Drawing.Point(248, 34);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(243, 23);
            this.btn_num.TabIndex = 1;
            this.btn_num.Text = "enumerar marcações";
            this.btn_num.UseVisualStyleBackColor = true;
            this.btn_num.Click += new System.EventHandler(this.btn_num_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(248, 63);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(243, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "limpar lista";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(248, 92);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(243, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "resetar lista";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(248, 191);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(243, 20);
            this.tb_add.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(248, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(243, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Location = new System.Drawing.Point(248, 172);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(101, 13);
            this.lb_add.TabIndex = 6;
            this.lb_add.Text = "Digite um novo task";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_num);
            this.Controls.Add(this.clb_tasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_tasks;
        private System.Windows.Forms.Button btn_num;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_add;
    }
}