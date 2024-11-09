namespace aracSatis
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.aracFiltrele = new System.Windows.Forms.Button();
            this.minFiyat = new System.Windows.Forms.NumericUpDown();
            this.maxFiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAracVites = new System.Windows.Forms.ComboBox();
            this.cbAracYakıt = new System.Windows.Forms.ComboBox();
            this.cbAracRenk = new System.Windows.Forms.ComboBox();
            this.cbAracMarka = new System.Windows.Forms.ComboBox();
            this.dgridListe = new System.Windows.Forms.DataGridView();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.cbSehir);
            this.splitContainer1.Panel1.Controls.Add(this.aracFiltrele);
            this.splitContainer1.Panel1.Controls.Add(this.minFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.maxFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbAracVites);
            this.splitContainer1.Panel1.Controls.Add(this.cbAracYakıt);
            this.splitContainer1.Panel1.Controls.Add(this.cbAracRenk);
            this.splitContainer1.Panel1.Controls.Add(this.cbAracMarka);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.dgridListe);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 588);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.TabIndex = 0;
            // 
            // aracFiltrele
            // 
            this.aracFiltrele.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aracFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aracFiltrele.ForeColor = System.Drawing.Color.White;
            this.aracFiltrele.Location = new System.Drawing.Point(99, 457);
            this.aracFiltrele.Name = "aracFiltrele";
            this.aracFiltrele.Size = new System.Drawing.Size(120, 63);
            this.aracFiltrele.TabIndex = 5;
            this.aracFiltrele.Text = "Araçları Listele";
            this.aracFiltrele.UseVisualStyleBackColor = false;
            this.aracFiltrele.Click += new System.EventHandler(this.aracFiltrele_Click);
            // 
            // minFiyat
            // 
            this.minFiyat.Location = new System.Drawing.Point(99, 406);
            this.minFiyat.Name = "minFiyat";
            this.minFiyat.Size = new System.Drawing.Size(120, 22);
            this.minFiyat.TabIndex = 4;
            // 
            // maxFiyat
            // 
            this.maxFiyat.Location = new System.Drawing.Point(100, 361);
            this.maxFiyat.Name = "maxFiyat";
            this.maxFiyat.Size = new System.Drawing.Size(120, 22);
            this.maxFiyat.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max:";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Min:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiyat Aralığı";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vites:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yakıt:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renk:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Araç Filtrele";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka:";
            // 
            // cbAracVites
            // 
            this.cbAracVites.FormattingEnabled = true;
            this.cbAracVites.Location = new System.Drawing.Point(99, 179);
            this.cbAracVites.Name = "cbAracVites";
            this.cbAracVites.Size = new System.Drawing.Size(121, 24);
            this.cbAracVites.TabIndex = 1;
            // 
            // cbAracYakıt
            // 
            this.cbAracYakıt.FormattingEnabled = true;
            this.cbAracYakıt.Location = new System.Drawing.Point(99, 141);
            this.cbAracYakıt.Name = "cbAracYakıt";
            this.cbAracYakıt.Size = new System.Drawing.Size(121, 24);
            this.cbAracYakıt.TabIndex = 1;
            // 
            // cbAracRenk
            // 
            this.cbAracRenk.FormattingEnabled = true;
            this.cbAracRenk.Location = new System.Drawing.Point(99, 101);
            this.cbAracRenk.Name = "cbAracRenk";
            this.cbAracRenk.Size = new System.Drawing.Size(121, 24);
            this.cbAracRenk.TabIndex = 1;
            // 
            // cbAracMarka
            // 
            this.cbAracMarka.FormattingEnabled = true;
            this.cbAracMarka.Location = new System.Drawing.Point(99, 58);
            this.cbAracMarka.Name = "cbAracMarka";
            this.cbAracMarka.Size = new System.Drawing.Size(121, 24);
            this.cbAracMarka.TabIndex = 0;
            // 
            // dgridListe
            // 
            this.dgridListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgridListe.Location = new System.Drawing.Point(0, 0);
            this.dgridListe.Name = "dgridListe";
            this.dgridListe.RowHeadersWidth = 51;
            this.dgridListe.RowTemplate.Height = 24;
            this.dgridListe.Size = new System.Drawing.Size(895, 588);
            this.dgridListe.TabIndex = 0;
            // 
            // cbSehir
            // 
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(99, 221);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(121, 24);
            this.cbSehir.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Şehir:";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1182, 588);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Araç Al";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAracRenk;
        private System.Windows.Forms.ComboBox cbAracMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAracVites;
        private System.Windows.Forms.ComboBox cbAracYakıt;
        private System.Windows.Forms.Button aracFiltrele;
        private System.Windows.Forms.NumericUpDown minFiyat;
        private System.Windows.Forms.NumericUpDown maxFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgridListe;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label label9;
    }
}

