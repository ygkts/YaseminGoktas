namespace Otobus_Otomasyon
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
            this.buttonBiletKes = new System.Windows.Forms.Button();
            this.buttonKontrol = new System.Windows.Forms.Button();
            this.buttonAracTakip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBiletKes
            // 
            this.buttonBiletKes.BackColor = System.Drawing.Color.Gray;
            this.buttonBiletKes.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBiletKes.Location = new System.Drawing.Point(672, 242);
            this.buttonBiletKes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBiletKes.Name = "buttonBiletKes";
            this.buttonBiletKes.Size = new System.Drawing.Size(299, 79);
            this.buttonBiletKes.TabIndex = 0;
            this.buttonBiletKes.Text = "Bilet Kes";
            this.buttonBiletKes.UseVisualStyleBackColor = false;
            this.buttonBiletKes.Click += new System.EventHandler(this.buttonBiletKes_Click);
            // 
            // buttonKontrol
            // 
            this.buttonKontrol.BackColor = System.Drawing.Color.Gray;
            this.buttonKontrol.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKontrol.Location = new System.Drawing.Point(672, 357);
            this.buttonKontrol.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKontrol.Name = "buttonKontrol";
            this.buttonKontrol.Size = new System.Drawing.Size(301, 76);
            this.buttonKontrol.TabIndex = 1;
            this.buttonKontrol.Text = "Kontrol";
            this.buttonKontrol.UseVisualStyleBackColor = false;
            this.buttonKontrol.Click += new System.EventHandler(this.buttonKontrol_Click);
            // 
            // buttonAracTakip
            // 
            this.buttonAracTakip.BackColor = System.Drawing.Color.Gray;
            this.buttonAracTakip.Font = new System.Drawing.Font("Lucida Bright", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAracTakip.Location = new System.Drawing.Point(672, 468);
            this.buttonAracTakip.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAracTakip.Name = "buttonAracTakip";
            this.buttonAracTakip.Size = new System.Drawing.Size(301, 73);
            this.buttonAracTakip.TabIndex = 2;
            this.buttonAracTakip.Text = "Araç Takip";
            this.buttonAracTakip.UseVisualStyleBackColor = false;
            this.buttonAracTakip.Click += new System.EventHandler(this.buttonAracTakip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBiletKes);
            this.groupBox1.Controls.Add(this.buttonKontrol);
            this.groupBox1.Controls.Add(this.buttonAracTakip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(13, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1107, 704);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "H O Ş G E L D İ N İ Z  -  Yapmak İstediğiniz İşlemi Seçiniz...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 37.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(144, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 72);
            this.label1.TabIndex = 5;
            this.label1.Text = "AYVANSARAY TURİZM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otobus_Otomasyon.Properties.Resources.ok;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1133, 719);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "AYVANSARAY TURİZM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBiletKes;
        private System.Windows.Forms.Button buttonKontrol;
        private System.Windows.Forms.Button buttonAracTakip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

