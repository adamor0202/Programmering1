namespace _9._7
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
            this.tbxTabell = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxNivå = new System.Windows.Forms.TextBox();
            this.Nivå = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxTabell
            // 
            this.tbxTabell.Location = new System.Drawing.Point(64, 218);
            this.tbxTabell.Multiline = true;
            this.tbxTabell.Name = "tbxTabell";
            this.tbxTabell.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxTabell.Size = new System.Drawing.Size(626, 191);
            this.tbxTabell.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Visa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxNivå
            // 
            this.tbxNivå.Location = new System.Drawing.Point(50, 87);
            this.tbxNivå.Name = "tbxNivå";
            this.tbxNivå.Size = new System.Drawing.Size(26, 20);
            this.tbxNivå.TabIndex = 2;
            // 
            // Nivå
            // 
            this.Nivå.AutoSize = true;
            this.Nivå.Location = new System.Drawing.Point(47, 68);
            this.Nivå.Name = "Nivå";
            this.Nivå.Size = new System.Drawing.Size(29, 13);
            this.Nivå.TabIndex = 3;
            this.Nivå.Text = "Nivå";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nivå);
            this.Controls.Add(this.tbxNivå);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxTabell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTabell;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxNivå;
        private System.Windows.Forms.Label Nivå;
    }
}

