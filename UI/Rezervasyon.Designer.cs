namespace UI
{
    partial class Rezervasyon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbRezCesidi = new System.Windows.Forms.ComboBox();
            this.panelKisiBilgisi = new System.Windows.Forms.Panel();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnSonrakiKisi = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerGiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCikis = new System.Windows.Forms.DateTimePicker();
            this.lblKisiSayisi = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnRezervasyonOlustur = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelOdalar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelKisiBilgisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbRezCesidi);
            this.panel1.Controls.Add(this.panelKisiBilgisi);
            this.panel1.Controls.Add(this.lblKisiSayisi);
            this.panel1.Controls.Add(this.btnTamamla);
            this.panel1.Controls.Add(this.btnRezervasyonOlustur);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panelOdalar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(24, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 354);
            this.panel1.TabIndex = 2;
            // 
            // cmbRezCesidi
            // 
            this.cmbRezCesidi.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbRezCesidi.FormattingEnabled = true;
            this.cmbRezCesidi.Location = new System.Drawing.Point(561, 38);
            this.cmbRezCesidi.Name = "cmbRezCesidi";
            this.cmbRezCesidi.Size = new System.Drawing.Size(159, 21);
            this.cmbRezCesidi.TabIndex = 0;
            // 
            // panelKisiBilgisi
            // 
            this.panelKisiBilgisi.Controls.Add(this.lblTelefon);
            this.panelKisiBilgisi.Controls.Add(this.txtTelefon);
            this.panelKisiBilgisi.Controls.Add(this.btnSonrakiKisi);
            this.panelKisiBilgisi.Controls.Add(this.txtAd);
            this.panelKisiBilgisi.Controls.Add(this.lblAd);
            this.panelKisiBilgisi.Controls.Add(this.lblTc);
            this.panelKisiBilgisi.Controls.Add(this.lblSoyad);
            this.panelKisiBilgisi.Controls.Add(this.txtSoyad);
            this.panelKisiBilgisi.Controls.Add(this.txtTCKN);
            this.panelKisiBilgisi.Controls.Add(this.label4);
            this.panelKisiBilgisi.Controls.Add(this.label5);
            this.panelKisiBilgisi.Controls.Add(this.dateTimePickerGiris);
            this.panelKisiBilgisi.Controls.Add(this.dateTimePickerCikis);
            this.panelKisiBilgisi.Location = new System.Drawing.Point(10, 15);
            this.panelKisiBilgisi.Margin = new System.Windows.Forms.Padding(2);
            this.panelKisiBilgisi.Name = "panelKisiBilgisi";
            this.panelKisiBilgisi.Size = new System.Drawing.Size(323, 269);
            this.panelKisiBilgisi.TabIndex = 17;
            this.panelKisiBilgisi.Visible = false;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelefon.Location = new System.Drawing.Point(2, 114);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(89, 15);
            this.lblTelefon.TabIndex = 12;
            this.lblTelefon.Text = "Telefon No : ";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(133, 113);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(162, 20);
            this.txtTelefon.TabIndex = 13;
            // 
            // btnSonrakiKisi
            // 
            this.btnSonrakiKisi.Location = new System.Drawing.Point(158, 234);
            this.btnSonrakiKisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonrakiKisi.Name = "btnSonrakiKisi";
            this.btnSonrakiKisi.Size = new System.Drawing.Size(116, 27);
            this.btnSonrakiKisi.TabIndex = 11;
            this.btnSonrakiKisi.Text = "Sonraki Kişi";
            this.btnSonrakiKisi.UseVisualStyleBackColor = true;
            this.btnSonrakiKisi.Click += new System.EventHandler(this.btnSonrakiKisi_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(133, 13);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(162, 20);
            this.txtAd.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAd.Location = new System.Drawing.Point(2, 13);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 15);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad : ";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTc.Location = new System.Drawing.Point(2, 75);
            this.lblTc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(102, 15);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "TC Kimlik No : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSoyad.Location = new System.Drawing.Point(2, 44);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(50, 15);
            this.lblSoyad.TabIndex = 5;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(133, 44);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(162, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(133, 74);
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(162, 20);
            this.txtTCKN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(2, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giriş Tarihi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(1, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Çıkış Tarihi : ";
            // 
            // dateTimePickerGiris
            // 
            this.dateTimePickerGiris.Location = new System.Drawing.Point(133, 161);
            this.dateTimePickerGiris.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerGiris.Name = "dateTimePickerGiris";
            this.dateTimePickerGiris.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerGiris.TabIndex = 9;
            // 
            // dateTimePickerCikis
            // 
            this.dateTimePickerCikis.Location = new System.Drawing.Point(133, 197);
            this.dateTimePickerCikis.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerCikis.Name = "dateTimePickerCikis";
            this.dateTimePickerCikis.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerCikis.TabIndex = 10;
            // 
            // lblKisiSayisi
            // 
            this.lblKisiSayisi.AutoSize = true;
            this.lblKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiSayisi.Location = new System.Drawing.Point(682, 296);
            this.lblKisiSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKisiSayisi.Name = "lblKisiSayisi";
            this.lblKisiSayisi.Size = new System.Drawing.Size(16, 17);
            this.lblKisiSayisi.TabIndex = 5;
            this.lblKisiSayisi.Text = "1";
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(189, 288);
            this.btnTamamla.Margin = new System.Windows.Forms.Padding(2);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(145, 47);
            this.btnTamamla.TabIndex = 16;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Visible = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnRezervasyonOlustur
            // 
            this.btnRezervasyonOlustur.Location = new System.Drawing.Point(40, 288);
            this.btnRezervasyonOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnRezervasyonOlustur.Name = "btnRezervasyonOlustur";
            this.btnRezervasyonOlustur.Size = new System.Drawing.Size(145, 47);
            this.btnRezervasyonOlustur.TabIndex = 16;
            this.btnRezervasyonOlustur.Text = "Rezervasyon Oluştur ";
            this.btnRezervasyonOlustur.UseVisualStyleBackColor = true;
            this.btnRezervasyonOlustur.Click += new System.EventHandler(this.btnRezervasyonOlustur_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(571, 291);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(557, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rezervasyon Çeşidi Seçiniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(614, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Kişi Sayısı:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(713, 292);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelOdalar
            // 
            this.panelOdalar.Location = new System.Drawing.Point(375, 38);
            this.panelOdalar.Margin = new System.Windows.Forms.Padding(2);
            this.panelOdalar.Name = "panelOdalar";
            this.panelOdalar.Size = new System.Drawing.Size(167, 232);
            this.panelOdalar.TabIndex = 14;
            this.panelOdalar.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOdalar_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(372, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oda Seçiniz : ";
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 466);
            this.Controls.Add(this.panel1);
            this.Name = "Rezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelKisiBilgisi.ResumeLayout(false);
            this.panelKisiBilgisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbRezCesidi;
        private System.Windows.Forms.Panel panelKisiBilgisi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnSonrakiKisi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerGiris;
        private System.Windows.Forms.DateTimePicker dateTimePickerCikis;
        private System.Windows.Forms.Label lblKisiSayisi;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnRezervasyonOlustur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelOdalar;
        private System.Windows.Forms.Label label6;
    }
}