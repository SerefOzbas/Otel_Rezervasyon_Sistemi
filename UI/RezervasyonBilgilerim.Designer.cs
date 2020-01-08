namespace UI
{
    partial class RezervasyonBilgilerim
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
            this.btnrezervasyonekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstvgecmisrezervasyonlistesi = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstvgelecekrezervaryonlistesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnrezervasyoniptal = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnrezervasyonekle
            // 
            this.btnrezervasyonekle.Location = new System.Drawing.Point(523, 351);
            this.btnrezervasyonekle.Name = "btnrezervasyonekle";
            this.btnrezervasyonekle.Size = new System.Drawing.Size(154, 46);
            this.btnrezervasyonekle.TabIndex = 11;
            this.btnrezervasyonekle.Text = "Rezervasyon Ekle";
            this.btnrezervasyonekle.UseVisualStyleBackColor = true;
            this.btnrezervasyonekle.Click += new System.EventHandler(this.Btnrezervasyonekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstvgecmisrezervasyonlistesi);
            this.groupBox2.Location = new System.Drawing.Point(6, 404);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 248);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geçmiş Rezervasyonlarım";
            // 
            // lstvgecmisrezervasyonlistesi
            // 
            this.lstvgecmisrezervasyonlistesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstvgecmisrezervasyonlistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvgecmisrezervasyonlistesi.GridLines = true;
            this.lstvgecmisrezervasyonlistesi.HideSelection = false;
            this.lstvgecmisrezervasyonlistesi.Location = new System.Drawing.Point(3, 16);
            this.lstvgecmisrezervasyonlistesi.Name = "lstvgecmisrezervasyonlistesi";
            this.lstvgecmisrezervasyonlistesi.Size = new System.Drawing.Size(666, 229);
            this.lstvgecmisrezervasyonlistesi.TabIndex = 1;
            this.lstvgecmisrezervasyonlistesi.UseCompatibleStateImageBehavior = false;
            this.lstvgecmisrezervasyonlistesi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ad";
            this.columnHeader7.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Soyad";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tc Kimlik No";
            this.columnHeader9.Width = 113;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Giriş Tarihi";
            this.columnHeader10.Width = 88;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Çıkış Tarihi";
            this.columnHeader11.Width = 99;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Kişi Sayısı";
            this.columnHeader12.Width = 88;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Total Fiyat";
            this.columnHeader13.Width = 81;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstvgelecekrezervaryonlistesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 269);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelecek Rezervasyonlarım";
            // 
            // lstvgelecekrezervaryonlistesi
            // 
            this.lstvgelecekrezervaryonlistesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader15,
            this.columnHeader6});
            this.lstvgelecekrezervaryonlistesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvgelecekrezervaryonlistesi.FullRowSelect = true;
            this.lstvgelecekrezervaryonlistesi.GridLines = true;
            this.lstvgelecekrezervaryonlistesi.HideSelection = false;
            this.lstvgelecekrezervaryonlistesi.Location = new System.Drawing.Point(3, 16);
            this.lstvgelecekrezervaryonlistesi.Name = "lstvgelecekrezervaryonlistesi";
            this.lstvgelecekrezervaryonlistesi.Size = new System.Drawing.Size(660, 250);
            this.lstvgelecekrezervaryonlistesi.TabIndex = 0;
            this.lstvgelecekrezervaryonlistesi.TabStop = false;
            this.lstvgelecekrezervaryonlistesi.UseCompatibleStateImageBehavior = false;
            this.lstvgelecekrezervaryonlistesi.View = System.Windows.Forms.View.Details;
            this.lstvgelecekrezervaryonlistesi.SelectedIndexChanged += new System.EventHandler(this.lstvgelecekrezervaryonlistesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyad";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tc Kimlik No";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giriş Tarihi";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Çıkış Tarihi";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kişi Sayısı";
            this.columnHeader15.Width = 76;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Fiyat";
            this.columnHeader6.Width = 140;
            // 
            // btnrezervasyoniptal
            // 
            this.btnrezervasyoniptal.Location = new System.Drawing.Point(367, 351);
            this.btnrezervasyoniptal.Name = "btnrezervasyoniptal";
            this.btnrezervasyoniptal.Size = new System.Drawing.Size(151, 46);
            this.btnrezervasyoniptal.TabIndex = 13;
            this.btnrezervasyoniptal.Text = "Rezervasyon İptal";
            this.btnrezervasyoniptal.UseVisualStyleBackColor = true;
            this.btnrezervasyoniptal.Click += new System.EventHandler(this.btnrezervasyoniptal_Click);
            // 
            // RezervasyonBilgilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 658);
            this.Controls.Add(this.btnrezervasyoniptal);
            this.Controls.Add(this.btnrezervasyonekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RezervasyonBilgilerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonBilgilerim";
            this.Load += new System.EventHandler(this.RezervasyonBilgilerim_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrezervasyonekle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvgelecekrezervaryonlistesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lstvgecmisrezervasyonlistesi;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnrezervasyoniptal;
    }
}