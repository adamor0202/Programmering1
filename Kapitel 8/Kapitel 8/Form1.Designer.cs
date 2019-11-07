namespace Kapitel_8
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
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.btnGissa = new System.Windows.Forms.Button();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.gbxSpelData = new System.Windows.Forms.GroupBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.gbxSpelData.SuspendLayout();
            this.gbxSpelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(6, 19);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(66, 13);
            this.lblStörstaTalet.TabIndex = 0;
            this.lblStörstaTalet.Text = "Största talet:";
            this.lblStörstaTalet.Click += new System.EventHandler(this.lblStörstaTalet_Click);
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(357, 145);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(95, 27);
            this.btnStartaSpelet.TabIndex = 1;
            this.btnStartaSpelet.Text = "Starta Spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(357, 178);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(95, 25);
            this.btnSpelaIgen.TabIndex = 2;
            this.btnSpelaIgen.Text = "Spela Igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.btnSpelaIgen_Click);
            // 
            // lblDator
            // 
            this.lblDator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDator.Location = new System.Drawing.Point(6, 84);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(100, 23);
            this.lblDator.TabIndex = 3;
            this.lblDator.Text = "Datorns Tal";
            this.lblDator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDator.Click += new System.EventHandler(this.lblDator_Click);
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(3, 126);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(62, 13);
            this.lblGissa.TabIndex = 4;
            this.lblGissa.Text = "Gissa ett tal";
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(106, 84);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(64, 23);
            this.lblDatornsTal.TabIndex = 5;
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(106, 123);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(64, 20);
            this.tbxGissa.TabIndex = 6;
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(0, 172);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(100, 23);
            this.lblResultat.TabIndex = 7;
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Location = new System.Drawing.Point(292, 86);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 8;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(301, 52);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(72, 13);
            this.lblMinaResultat.TabIndex = 9;
            this.lblMinaResultat.Text = "Mina Resultat";
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(191, 121);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 10;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(83, 19);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(90, 30);
            this.lbxStörstaTalet.TabIndex = 11;
            // 
            // gbxSpelData
            // 
            this.gbxSpelData.Controls.Add(this.lblStörstaTalet);
            this.gbxSpelData.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpelData.Location = new System.Drawing.Point(34, 140);
            this.gbxSpelData.Name = "gbxSpelData";
            this.gbxSpelData.Size = new System.Drawing.Size(260, 67);
            this.gbxSpelData.TabIndex = 12;
            this.gbxSpelData.TabStop = false;
            this.gbxSpelData.Text = "SpelData";
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblMinaResultat);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Location = new System.Drawing.Point(28, 228);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(424, 221);
            this.gbxSpelet.TabIndex = 13;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            this.gbxSpelet.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.gbxSpelData);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.btnStartaSpelet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSpelData.ResumeLayout(false);
            this.gbxSpelData.PerformLayout();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStörstaTalet;
        private System.Windows.Forms.Button btnStartaSpelet;
        private System.Windows.Forms.Button btnSpelaIgen;
        private System.Windows.Forms.Label lblDator;
        private System.Windows.Forms.Label lblGissa;
        private System.Windows.Forms.Label lblDatornsTal;
        private System.Windows.Forms.TextBox tbxGissa;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox tbxMinaResultat;
        private System.Windows.Forms.Label lblMinaResultat;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.ListBox lbxStörstaTalet;
        private System.Windows.Forms.GroupBox gbxSpelData;
        private System.Windows.Forms.GroupBox gbxSpelet;
    }
}

