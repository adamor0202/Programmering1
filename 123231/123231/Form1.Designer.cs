﻿namespace _123231
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxTid = new System.Windows.Forms.TextBox();
            this.lblTid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(237, 227);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 0;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tid i sekunder:";
            // 
            // textboxTid
            // 
            this.textboxTid.Location = new System.Drawing.Point(290, 134);
            this.textboxTid.Name = "textboxTid";
            this.textboxTid.Size = new System.Drawing.Size(54, 20);
            this.textboxTid.TabIndex = 2;
            this.textboxTid.TextChanged += new System.EventHandler(this.tbxTid_TextChanged);
            // 
            // lblTid
            // 
            this.lblTid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTid.Location = new System.Drawing.Point(143, 180);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(278, 19);
            this.lblTid.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.textboxTid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVisa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxTid;
        private System.Windows.Forms.Label lblTid;
    }
}

