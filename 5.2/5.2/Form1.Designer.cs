namespace _5._2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonKör = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ButtonKör
            // 
            this.ButtonKör.Location = new System.Drawing.Point(249, 163);
            this.ButtonKör.Name = "ButtonKör";
            this.ButtonKör.Size = new System.Drawing.Size(75, 23);
            this.ButtonKör.TabIndex = 1;
            this.ButtonKör.Text = "Kör";
            this.ButtonKör.UseVisualStyleBackColor = true;
            this.ButtonKör.Click += new System.EventHandler(this.ButtonKör_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tal";
            // 
            // LabelSvar
            // 
            this.LabelSvar.AutoSize = true;
            this.LabelSvar.Location = new System.Drawing.Point(274, 118);
            this.LabelSvar.Name = "LabelSvar";
            this.LabelSvar.Size = new System.Drawing.Size(0, 13);
            this.LabelSvar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelSvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonKör);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonKör;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSvar;
    }
}

