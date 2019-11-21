namespace _10._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.tbxRadie = new System.Windows.Forms.TextBox();
            this.btnBeräkna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area";
            // 
            // lblArea
            // 
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArea.Location = new System.Drawing.Point(278, 157);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(100, 23);
            this.lblArea.TabIndex = 2;
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxRadie
            // 
            this.tbxRadie.Location = new System.Drawing.Point(278, 125);
            this.tbxRadie.Name = "tbxRadie";
            this.tbxRadie.Size = new System.Drawing.Size(100, 20);
            this.tbxRadie.TabIndex = 3;
            // 
            // btnBeräkna
            // 
            this.btnBeräkna.Location = new System.Drawing.Point(278, 209);
            this.btnBeräkna.Name = "btnBeräkna";
            this.btnBeräkna.Size = new System.Drawing.Size(75, 23);
            this.btnBeräkna.TabIndex = 4;
            this.btnBeräkna.Text = "Beräkna";
            this.btnBeräkna.UseVisualStyleBackColor = true;
            this.btnBeräkna.Click += new System.EventHandler(this.btnBeräkna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeräkna);
            this.Controls.Add(this.tbxRadie);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox tbxRadie;
        private System.Windows.Forms.Button btnBeräkna;
    }
}

