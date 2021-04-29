
namespace Form2
{
    partial class F_ComboBox
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
            this.cb_Atividades = new System.Windows.Forms.ComboBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Atividades
            // 
            this.cb_Atividades.FormattingEnabled = true;
            this.cb_Atividades.Items.AddRange(new object[] {
            "atividade1 ",
            "atividade2",
            "atividade3",
            "atividade4"});
            this.cb_Atividades.Location = new System.Drawing.Point(12, 14);
            this.cb_Atividades.Name = "cb_Atividades";
            this.cb_Atividades.Size = new System.Drawing.Size(286, 21);
            this.cb_Atividades.TabIndex = 0;
            this.cb_Atividades.SelectedIndexChanged += new System.EventHandler(this.cb_Atividades_SelectedIndexChanged);
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(330, 12);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(250, 23);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "Mostrar selecionados";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(330, 41);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(250, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(330, 70);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(250, 23);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(330, 115);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(250, 20);
            this.tb_add.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(330, 141);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(250, 23);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_add);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.cb_Atividades);
            this.Name = "F_ComboBox";
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Atividades;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tb_add;
        private System.Windows.Forms.Button btn_add;
    }
}