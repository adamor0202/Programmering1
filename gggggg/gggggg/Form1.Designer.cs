namespace gggggg
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
            this.btnVisa = new System.Windows.Forms.Button();
            this.tbxRutor = new System.Windows.Forms.TextBox();
            this.btnVisa2 = new System.Windows.Forms.Button();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(86, 12);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // tbxRutor
            // 
            this.tbxRutor.Location = new System.Drawing.Point(23, 66);
            this.tbxRutor.Multiline = true;
            this.tbxRutor.Name = "tbxRutor";
            this.tbxRutor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRutor.Size = new System.Drawing.Size(201, 201);
            this.tbxRutor.TabIndex = 1;
            // 
            // btnVisa2
            // 
            this.btnVisa2.Location = new System.Drawing.Point(601, 11);
            this.btnVisa2.Name = "btnVisa2";
            this.btnVisa2.Size = new System.Drawing.Size(75, 23);
            this.btnVisa2.TabIndex = 2;
            this.btnVisa2.Text = "Visa";
            this.btnVisa2.UseVisualStyleBackColor = true;
            this.btnVisa2.Click += new System.EventHandler(this.btnVisa2_Click);
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(506, 56);
            this.tbxSumma.Multiline = true;
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(256, 211);
            this.tbxSumma.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(692, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 626);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.btnVisa2);
            this.Controls.Add(this.tbxRutor);
            this.Controls.Add(this.btnVisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.TextBox tbxRutor;
        private System.Windows.Forms.Button btnVisa2;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.TextBox textBox1;
    }
}

