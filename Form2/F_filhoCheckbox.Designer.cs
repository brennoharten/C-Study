
namespace Form2
{
    partial class F_filhoCheckbox
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
            this.Atividade4 = new System.Windows.Forms.CheckBox();
            this.Atividade3 = new System.Windows.Forms.CheckBox();
            this.Atividade2 = new System.Windows.Forms.CheckBox();
            this.Atividade1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Atividade4
            // 
            this.Atividade4.AutoSize = true;
            this.Atividade4.Location = new System.Drawing.Point(21, 95);
            this.Atividade4.Name = "Atividade4";
            this.Atividade4.Size = new System.Drawing.Size(75, 17);
            this.Atividade4.TabIndex = 7;
            this.Atividade4.Text = "atividade4";
            this.Atividade4.UseVisualStyleBackColor = true;
            this.Atividade4.CheckedChanged += new System.EventHandler(this.Atividade4_CheckedChanged);
            // 
            // Atividade3
            // 
            this.Atividade3.AutoSize = true;
            this.Atividade3.Location = new System.Drawing.Point(21, 71);
            this.Atividade3.Name = "Atividade3";
            this.Atividade3.Size = new System.Drawing.Size(75, 17);
            this.Atividade3.TabIndex = 6;
            this.Atividade3.Text = "atividade3";
            this.Atividade3.UseVisualStyleBackColor = true;
            this.Atividade3.CheckedChanged += new System.EventHandler(this.Atividade3_CheckedChanged);
            // 
            // Atividade2
            // 
            this.Atividade2.AutoSize = true;
            this.Atividade2.Location = new System.Drawing.Point(21, 47);
            this.Atividade2.Name = "Atividade2";
            this.Atividade2.Size = new System.Drawing.Size(75, 17);
            this.Atividade2.TabIndex = 5;
            this.Atividade2.Text = "atividade2";
            this.Atividade2.UseVisualStyleBackColor = true;
            this.Atividade2.CheckedChanged += new System.EventHandler(this.Atividade2_CheckedChanged);
            // 
            // Atividade1
            // 
            this.Atividade1.AutoSize = true;
            this.Atividade1.Location = new System.Drawing.Point(21, 23);
            this.Atividade1.Name = "Atividade1";
            this.Atividade1.Size = new System.Drawing.Size(75, 17);
            this.Atividade1.TabIndex = 4;
            this.Atividade1.Text = "atividade1";
            this.Atividade1.UseVisualStyleBackColor = true;
            this.Atividade1.CheckedChanged += new System.EventHandler(this.Atividade1_CheckedChanged);
            // 
            // F_filhoCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 284);
            this.Controls.Add(this.Atividade4);
            this.Controls.Add(this.Atividade3);
            this.Controls.Add(this.Atividade2);
            this.Controls.Add(this.Atividade1);
            this.MaximizeBox = false;
            this.Name = "F_filhoCheckbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_filhoCheckbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Atividade4;
        private System.Windows.Forms.CheckBox Atividade3;
        private System.Windows.Forms.CheckBox Atividade2;
        private System.Windows.Forms.CheckBox Atividade1;
    }
}