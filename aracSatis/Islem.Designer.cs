namespace aracSatis
{
    partial class Islem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islem));
            this.label1 = new System.Windows.Forms.Label();
            this.bAracAl = new System.Windows.Forms.Button();
            this.bAracSat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "LÜTFEN YAPMAK İSTEDİĞİNİZ \r\n       İŞLEMİ SEÇERMİSİNİZ";
            // 
            // bAracAl
            // 
            this.bAracAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAracAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAracAl.ForeColor = System.Drawing.Color.White;
            this.bAracAl.Location = new System.Drawing.Point(30, 318);
            this.bAracAl.Name = "bAracAl";
            this.bAracAl.Size = new System.Drawing.Size(144, 71);
            this.bAracAl.TabIndex = 1;
            this.bAracAl.Text = "Araç Al";
            this.bAracAl.UseVisualStyleBackColor = false;
            this.bAracAl.Click += new System.EventHandler(this.bAracAl_Click);
            // 
            // bAracSat
            // 
            this.bAracSat.BackColor = System.Drawing.Color.Maroon;
            this.bAracSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAracSat.ForeColor = System.Drawing.Color.White;
            this.bAracSat.Location = new System.Drawing.Point(270, 318);
            this.bAracSat.Name = "bAracSat";
            this.bAracSat.Size = new System.Drawing.Size(144, 71);
            this.bAracSat.TabIndex = 2;
            this.bAracSat.Text = "Araç Sat";
            this.bAracSat.UseVisualStyleBackColor = false;
            this.bAracSat.Click += new System.EventHandler(this.bAracSat_Click);
            // 
            // Islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 496);
            this.Controls.Add(this.bAracSat);
            this.Controls.Add(this.bAracAl);
            this.Controls.Add(this.label1);
            this.Name = "Islem";
            this.Text = "Islem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAracAl;
        private System.Windows.Forms.Button bAracSat;
    }
}