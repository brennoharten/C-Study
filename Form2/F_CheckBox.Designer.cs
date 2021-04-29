
namespace Form2
{
    partial class F_CheckBox
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
            this.Atividade1 = new System.Windows.Forms.CheckBox();
            this.Atividade2 = new System.Windows.Forms.CheckBox();
            this.Atividade3 = new System.Windows.Forms.CheckBox();
            this.Atividade4 = new System.Windows.Forms.CheckBox();
            this.btn_Atividades = new System.Windows.Forms.Button();
            this.btn_filho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Atividade1
            // 
            this.Atividade1.AutoSize = true;
            this.Atividade1.Location = new System.Drawing.Point(27, 23);
            this.Atividade1.Name = "Atividade1";
            this.Atividade1.Size = new System.Drawing.Size(75, 17);
            this.Atividade1.TabIndex = 0;
            this.Atividade1.Text = "atividade1";
            this.Atividade1.UseVisualStyleBackColor = true;
            // 
            // Atividade2
            // 
            this.Atividade2.AutoSize = true;
            this.Atividade2.Location = new System.Drawing.Point(27, 47);
            this.Atividade2.Name = "Atividade2";
            this.Atividade2.Size = new System.Drawing.Size(75, 17);
            this.Atividade2.TabIndex = 1;
            this.Atividade2.Text = "atividade2";
            this.Atividade2.UseVisualStyleBackColor = true;
            // 
            // Atividade3
            // 
            this.Atividade3.AutoSize = true;
            this.Atividade3.Location = new System.Drawing.Point(27, 71);
            this.Atividade3.Name = "Atividade3";
            this.Atividade3.Size = new System.Drawing.Size(75, 17);
            this.Atividade3.TabIndex = 2;
            this.Atividade3.Text = "atividade3";
            this.Atividade3.UseVisualStyleBackColor = true;
            // 
            // Atividade4
            // 
            this.Atividade4.AutoSize = true;
            this.Atividade4.Location = new System.Drawing.Point(27, 95);
            this.Atividade4.Name = "Atividade4";
            this.Atividade4.Size = new System.Drawing.Size(75, 17);
            this.Atividade4.TabIndex = 3;
            this.Atividade4.Text = "atividade4";
            this.Atividade4.UseVisualStyleBackColor = true;
            // 
            // btn_Atividades
            // 
            this.btn_Atividades.Location = new System.Drawing.Point(206, 23);
            this.btn_Atividades.Name = "btn_Atividades";
            this.btn_Atividades.Size = new System.Drawing.Size(160, 23);
            this.btn_Atividades.TabIndex = 4;
            this.btn_Atividades.Text = "Atividades concluidas";
            this.btn_Atividades.UseVisualStyleBackColor = true;
            this.btn_Atividades.Click += new System.EventHandler(this.btn_Atividades_Click);
            // 
            // btn_filho
            // 
            this.btn_filho.Location = new System.Drawing.Point(206, 53);
            this.btn_filho.Name = "btn_filho";
            this.btn_filho.Size = new System.Drawing.Size(160, 23);
            this.btn_filho.TabIndex = 5;
            this.btn_filho.Text = "chamar o filho";
            this.btn_filho.UseVisualStyleBackColor = true;
            this.btn_filho.Click += new System.EventHandler(this.btn_filho_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 309);
            this.Controls.Add(this.btn_filho);
            this.Controls.Add(this.btn_Atividades);
            this.Controls.Add(this.Atividade4);
            this.Controls.Add(this.Atividade3);
            this.Controls.Add(this.Atividade2);
            this.Controls.Add(this.Atividade1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Atividades;
        public System.Windows.Forms.CheckBox Atividade1;
        public System.Windows.Forms.CheckBox Atividade2;
        public System.Windows.Forms.CheckBox Atividade3;
        public System.Windows.Forms.CheckBox Atividade4;
        private System.Windows.Forms.Button btn_filho;
    }
}