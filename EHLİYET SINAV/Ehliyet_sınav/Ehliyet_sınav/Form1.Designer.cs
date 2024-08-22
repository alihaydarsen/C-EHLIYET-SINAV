namespace Ehliyet_sınav
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bA = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsoruno = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlış = new System.Windows.Forms.Label();
            this.bBASLA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bBİTİR = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(818, 394);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bA
            // 
            this.bA.Enabled = false;
            this.bA.Location = new System.Drawing.Point(23, 443);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(1235, 58);
            this.bA.TabIndex = 2;
            this.bA.Text = "A";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // bB
            // 
            this.bB.Enabled = false;
            this.bB.Location = new System.Drawing.Point(23, 511);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(1235, 58);
            this.bB.TabIndex = 3;
            this.bB.Text = "B";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // bD
            // 
            this.bD.Enabled = false;
            this.bD.Location = new System.Drawing.Point(23, 639);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(1235, 58);
            this.bD.TabIndex = 5;
            this.bD.Text = "D";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bC
            // 
            this.bC.Enabled = false;
            this.bC.Location = new System.Drawing.Point(23, 575);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(1235, 58);
            this.bC.TabIndex = 4;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "SORU:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(849, 105);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(120, 35);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "DOĞRU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(853, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "YANLIŞ:";
            // 
            // lblsoruno
            // 
            this.lblsoruno.AutoSize = true;
            this.lblsoruno.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruno.Location = new System.Drawing.Point(972, 24);
            this.lblsoruno.Name = "lblsoruno";
            this.lblsoruno.Size = new System.Drawing.Size(36, 41);
            this.lblsoruno.TabIndex = 9;
            this.lblsoruno.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.Location = new System.Drawing.Point(972, 105);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(36, 41);
            this.lbldogru.TabIndex = 10;
            this.lbldogru.Text = "0";
            // 
            // lblyanlış
            // 
            this.lblyanlış.AutoSize = true;
            this.lblyanlış.Font = new System.Drawing.Font("Corbel", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlış.Location = new System.Drawing.Point(972, 180);
            this.lblyanlış.Name = "lblyanlış";
            this.lblyanlış.Size = new System.Drawing.Size(36, 41);
            this.lblyanlış.TabIndex = 11;
            this.lblyanlış.Text = "0";
            // 
            // bBASLA
            // 
            this.bBASLA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBASLA.Location = new System.Drawing.Point(1139, 24);
            this.bBASLA.Name = "bBASLA";
            this.bBASLA.Size = new System.Drawing.Size(119, 102);
            this.bBASLA.TabIndex = 12;
            this.bBASLA.Text = "BAŞLA";
            this.bBASLA.UseVisualStyleBackColor = true;
            this.bBASLA.Click += new System.EventHandler(this.bSONRAKİ_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(855, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 162);
            this.button1.TabIndex = 13;
            this.button1.Text = "SONRAKİ ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(305, 700);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 35);
            this.label7.TabIndex = 14;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(741, 700);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 35);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            // 
            // bBİTİR
            // 
            this.bBİTİR.Enabled = false;
            this.bBİTİR.Location = new System.Drawing.Point(1139, 145);
            this.bBİTİR.Name = "bBİTİR";
            this.bBİTİR.Size = new System.Drawing.Size(119, 102);
            this.bBİTİR.TabIndex = 16;
            this.bBİTİR.Text = "BİTİR";
            this.bBİTİR.UseVisualStyleBackColor = true;
            this.bBİTİR.Click += new System.EventHandler(this.bBİTİR_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1014, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1014, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1014, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 700);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBİTİR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bBASLA);
            this.Controls.Add(this.lblyanlış);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblsoruno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bD);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bB);
            this.Controls.Add(this.bA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "EHLİYET SINAV";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsoruno;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblyanlış;
        private System.Windows.Forms.Button bBASLA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bBİTİR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

