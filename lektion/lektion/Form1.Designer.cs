namespace lektion
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
            this.Tal1 = new System.Windows.Forms.Label();
            this.raknesatt = new System.Windows.Forms.Label();
            this.Tal2 = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.btnSvar = new System.Windows.Forms.Button();
            this.boxTal2 = new System.Windows.Forms.TextBox();
            this.BoxRaknesatt = new System.Windows.Forms.TextBox();
            this.boxTal1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Tal1
            // 
            this.Tal1.AutoSize = true;
            this.Tal1.Location = new System.Drawing.Point(82, 50);
            this.Tal1.Name = "Tal1";
            this.Tal1.Size = new System.Drawing.Size(31, 13);
            this.Tal1.TabIndex = 0;
            this.Tal1.Text = "Tal 1";
            // 
            // raknesatt
            // 
            this.raknesatt.AutoSize = true;
            this.raknesatt.Location = new System.Drawing.Point(82, 96);
            this.raknesatt.Name = "raknesatt";
            this.raknesatt.Size = new System.Drawing.Size(56, 13);
            this.raknesatt.TabIndex = 1;
            this.raknesatt.Text = "Räknesätt";
            // 
            // Tal2
            // 
            this.Tal2.AutoSize = true;
            this.Tal2.Location = new System.Drawing.Point(85, 141);
            this.Tal2.Name = "Tal2";
            this.Tal2.Size = new System.Drawing.Size(28, 13);
            this.Tal2.TabIndex = 2;
            this.Tal2.Text = "Tal2";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(204, 180);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 13);
            this.lblSvar.TabIndex = 3;
            // 
            // btnSvar
            // 
            this.btnSvar.Location = new System.Drawing.Point(207, 222);
            this.btnSvar.Name = "btnSvar";
            this.btnSvar.Size = new System.Drawing.Size(75, 23);
            this.btnSvar.TabIndex = 4;
            this.btnSvar.Text = "Beräkna";
            this.btnSvar.UseVisualStyleBackColor = true;
            this.btnSvar.Click += new System.EventHandler(this.BtnSvar_Click);
            // 
            // boxTal2
            // 
            this.boxTal2.Location = new System.Drawing.Point(207, 141);
            this.boxTal2.Name = "boxTal2";
            this.boxTal2.Size = new System.Drawing.Size(100, 20);
            this.boxTal2.TabIndex = 5;
            // 
            // BoxRaknesatt
            // 
            this.BoxRaknesatt.Location = new System.Drawing.Point(207, 96);
            this.BoxRaknesatt.Name = "BoxRaknesatt";
            this.BoxRaknesatt.Size = new System.Drawing.Size(100, 20);
            this.BoxRaknesatt.TabIndex = 6;
            // 
            // boxTal1
            // 
            this.boxTal1.Location = new System.Drawing.Point(207, 50);
            this.boxTal1.Name = "boxTal1";
            this.boxTal1.Size = new System.Drawing.Size(100, 20);
            this.boxTal1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxTal1);
            this.Controls.Add(this.BoxRaknesatt);
            this.Controls.Add(this.boxTal2);
            this.Controls.Add(this.btnSvar);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.Tal2);
            this.Controls.Add(this.raknesatt);
            this.Controls.Add(this.Tal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tal1;
        private System.Windows.Forms.Label raknesatt;
        private System.Windows.Forms.Label Tal2;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Button btnSvar;
        private System.Windows.Forms.TextBox boxTal2;
        private System.Windows.Forms.TextBox BoxRaknesatt;
        private System.Windows.Forms.TextBox boxTal1;
    }
}

