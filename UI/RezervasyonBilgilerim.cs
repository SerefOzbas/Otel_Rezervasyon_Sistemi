using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace UI
{
    public partial class RezervasyonBilgilerim : MaterialForm
    {

        UyeBLL _uyeBLL;
        MusteriBLL _musteriBLL;
        OdaBLL _odaBLL;
        RezervasyonBLL _rezervasyonBLL;
        MusteriRezervasyonBLL _MusRezBLL;

        public RezervasyonBilgilerim()
        {
           
            InitializeComponent();
            _uyeBLL = new UyeBLL();
            _musteriBLL = new MusteriBLL();
            _odaBLL = new OdaBLL();
            _rezervasyonBLL = new RezervasyonBLL();
            _MusRezBLL = new MusteriRezervasyonBLL();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }

        private void RezervasyonBilgilerim_Load(object sender, EventArgs e)
        {
            Frm_ListDoldur();
        }

        private void Btnrezervasyonekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.FormClosing += Rezervasyon_FormClosing; 
            rezervasyon.Show();
        }

        private void Rezervasyon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void Frm_ListDoldur()
        {
            lstvgelecekrezervaryonlistesi.Items.Clear();
            lstvgecmisrezervasyonlistesi.Items.Clear();
            List<Entities.Rezervasyon> rezervasyon = _rezervasyonBLL.UyeIDileListele(frm_GirisEkrani.girisId);
            ListViewItem lvi;
            foreach (var item in rezervasyon)
            {
                lvi = new ListViewItem();
                lvi.Text = item.Ad.ToString();
                lvi.SubItems.Add(item.Soyad.ToString());
                lvi.SubItems.Add(item.TCKN.ToString());
                lvi.SubItems.Add(item.GirisTarihi.ToString());
                lvi.SubItems.Add(item.CikisTarihi.ToString());
                lvi.SubItems.Add(item.KisiSayisi.ToString()+" kişilik oda");
                lvi.SubItems.Add(item.TotalFiyat.ToString()+ " (Kişi başı günlük ücret)");

                lvi.Tag = item;

                if (item.GirisTarihi < DateTime.Now.Date)
                {
                    lstvgecmisrezervasyonlistesi.Items.Add(lvi);
                }
                else if (item.GirisTarihi >= DateTime.Now.Date)
                {
                    lstvgelecekrezervaryonlistesi.Items.Add(lvi);
                }
            }
        }

        private void btnrezervasyoniptal_Click(object sender, EventArgs e)
        {
            if (lstvgelecekrezervaryonlistesi.FocusedItem == null)
            {
                MessageBox.Show("Lütfen bir rezervasyon seçiniz");
                return;
            }
            DialogResult result = MessageBox.Show("bu rezervasyonu iptal etmek istediğinizden emin misiniz?", "Rezervasyon İptal Onayı", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
              
                _odaBLL.SilUpdate(lstvgelecekrezervaryonlistesi.FocusedItem.Tag as Entities.Rezervasyon);
                _MusRezBLL.Sil((lstvgelecekrezervaryonlistesi.FocusedItem.Tag as Entities.Rezervasyon));
                bool isDeleted = _rezervasyonBLL.Sil(lstvgelecekrezervaryonlistesi.FocusedItem.Tag as Entities.Rezervasyon);
                
            
                if (isDeleted)
                {
                    MessageBox.Show("Rezervasyon başarıyla silindi");
                }
                else
                {
                    MessageBox.Show("Rezervasyon silme işleminiz başarısız");
                }
            }
            Frm_ListDoldur();
        }


        private void RezervasyonIptalButonu()
        {
            Entities.Rezervasyon rezervasyon = new Entities.Rezervasyon();
            rezervasyon = (Entities.Rezervasyon)lstvgelecekrezervaryonlistesi.FocusedItem.Tag;
            for (int i = 0; i < lstvgelecekrezervaryonlistesi.Items.Count; i++)
            {
                if (rezervasyon.GirisTarihi <= DateTime.Now.AddDays(6))
                {
                    btnrezervasyoniptal.Enabled = false;
                }
                else
                {
                    btnrezervasyoniptal.Enabled = true;
                }
            }

        }

        private void lstvgelecekrezervaryonlistesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            RezervasyonIptalButonu();
        }
    }
}