namespace Otobus_Otomasyon
{
    partial class Form_AracTakip
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
            this.txtKisiSayisi = new System.Windows.Forms.TextBox();
            this.comboBoxOtobusSec = new System.Windows.Forms.ComboBox();
            this.btnAraccDUrumKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSefer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAracHareketlendir = new System.Windows.Forms.Button();
            this.btnGunlukArsiv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxKayitArsiv = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKisiSayisi
            // 
            this.txtKisiSayisi.Enabled = false;
            this.txtKisiSayisi.Location = new System.Drawing.Point(155, 90);
            this.txtKisiSayisi.Name = "txtKisiSayisi";
            this.txtKisiSayisi.Size = new System.Drawing.Size(218, 22);
            this.txtKisiSayisi.TabIndex = 5;
            // 
            // comboBoxOtobusSec
            // 
            this.comboBoxOtobusSec.FormattingEnabled = true;
            this.comboBoxOtobusSec.Location = new System.Drawing.Point(155, 48);
            this.comboBoxOtobusSec.Name = "comboBoxOtobusSec";
            this.comboBoxOtobusSec.Size = new System.Drawing.Size(218, 24);
            this.comboBoxOtobusSec.TabIndex = 4;
            this.comboBoxOtobusSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtobusSec_SelectedIndexChanged);
            // 
            // btnAraccDUrumKaydet
            // 
            this.btnAraccDUrumKaydet.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnAraccDUrumKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraccDUrumKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAraccDUrumKaydet.Location = new System.Drawing.Point(44, 549);
            this.btnAraccDUrumKaydet.Name = "btnAraccDUrumKaydet";
            this.btnAraccDUrumKaydet.Size = new System.Drawing.Size(241, 58);
            this.btnAraccDUrumKaydet.TabIndex = 6;
            this.btnAraccDUrumKaydet.Text = "ARAÇ DURUM KAYDET";
            this.btnAraccDUrumKaydet.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sefer :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(1075, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Günlük Kayıt Arşivi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kişi Sayısı :";
            // 
            // txtSefer
            // 
            this.txtSefer.Enabled = false;
            this.txtSefer.Location = new System.Drawing.Point(155, 131);
            this.txtSefer.Name = "txtSefer";
            this.txtSefer.Size = new System.Drawing.Size(218, 22);
            this.txtSefer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Otobüs :";
            // 
            // buttonAracHareketlendir
            // 
            this.buttonAracHareketlendir.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonAracHareketlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAracHareketlendir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAracHareketlendir.Location = new System.Drawing.Point(44, 180);
            this.buttonAracHareketlendir.Name = "buttonAracHareketlendir";
            this.buttonAracHareketlendir.Size = new System.Drawing.Size(549, 49);
            this.buttonAracHareketlendir.TabIndex = 6;
            this.buttonAracHareketlendir.Text = "ARAÇ HAREKETLENDİR";
            this.buttonAracHareketlendir.UseVisualStyleBackColor = false;
            this.buttonAracHareketlendir.Click += new System.EventHandler(this.buttonAracHareketlendir_Click);
            // 
            // btnGunlukArsiv
            // 
            this.btnGunlukArsiv.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGunlukArsiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunlukArsiv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGunlukArsiv.Location = new System.Drawing.Point(352, 549);
            this.btnGunlukArsiv.Name = "btnGunlukArsiv";
            this.btnGunlukArsiv.Size = new System.Drawing.Size(241, 58);
            this.btnGunlukArsiv.TabIndex = 6;
            this.btnGunlukArsiv.Text = "GÜNLÜK ARŞİV";
            this.btnGunlukArsiv.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(44, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 271);
            this.dataGridView1.TabIndex = 7;
            // 
            // listBoxKayitArsiv
            // 
            this.listBoxKayitArsiv.FormattingEnabled = true;
            this.listBoxKayitArsiv.ItemHeight = 16;
            this.listBoxKayitArsiv.Location = new System.Drawing.Point(1079, 85);
            this.listBoxKayitArsiv.Name = "listBoxKayitArsiv";
            this.listBoxKayitArsiv.Size = new System.Drawing.Size(227, 516);
            this.listBoxKayitArsiv.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.listBoxKayitArsiv);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnGunlukArsiv);
            this.groupBox1.Controls.Add(this.buttonAracHareketlendir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSefer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAraccDUrumKaydet);
            this.groupBox1.Controls.Add(this.comboBoxOtobusSec);
            this.groupBox1.Controls.Add(this.txtKisiSayisi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1334, 738);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Takibi";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PLAKA";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TARİH";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TOPLAM HASILAT";
            this.Column3.Name = "Column3";
            // 
            // Form_AracTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Otobus_Otomasyon.Properties.Resources.california_210913_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1388, 792);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_AracTakip";
            this.Text = "Form_AracTakip";
            this.Load += new System.EventHandler(this.Form_AracTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKisiSayisi;
        private System.Windows.Forms.ComboBox comboBoxOtobusSec;
        private System.Windows.Forms.Button btnAraccDUrumKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSefer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAracHareketlendir;
        private System.Windows.Forms.Button btnGunlukArsiv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxKayitArsiv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}