namespace _5._4upp
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTimmar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMinuter = new System.Windows.Forms.Label();
            this.labelSekunder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sekunder";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelTimmar
            // 
            this.labelTimmar.AutoSize = true;
            this.labelTimmar.Location = new System.Drawing.Point(284, 133);
            this.labelTimmar.Name = "labelTimmar";
            this.labelTimmar.Size = new System.Drawing.Size(0, 13);
            this.labelTimmar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // labelMinuter
            // 
            this.labelMinuter.AutoSize = true;
            this.labelMinuter.Location = new System.Drawing.Point(350, 133);
            this.labelMinuter.Name = "labelMinuter";
            this.labelMinuter.Size = new System.Drawing.Size(0, 13);
            this.labelMinuter.TabIndex = 4;
            // 
            // labelSekunder
            // 
            this.labelSekunder.AutoSize = true;
            this.labelSekunder.Location = new System.Drawing.Point(419, 132);
            this.labelSekunder.Name = "labelSekunder";
            this.labelSekunder.Size = new System.Drawing.Size(0, 13);
            this.labelSekunder.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.labelSekunder);
            this.Controls.Add(this.labelMinuter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTimmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTimmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMinuter;
        private System.Windows.Forms.Label labelSekunder;
    }
}

