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
    public partial class Rezervasyon : MaterialForm
    {
        public static int KisiSayisi = 1;

        List<Musteri> musteriler = new List<Musteri>();
        List<ComboBox> eklenenOdalar = new List<ComboBox>();


        RezervasyonCesidi RC;
        RezervasyonCesidiBLL RCBLL;
        OdaCesidiBLL OBLL;
        OdaBLL _odaBLL;
        MusteriBLL _musteriBLL;
        RezervasyonBLL _rezervasyonBLL;
        OdaVeOdaCesidiBLL OVCBLL;
        ComboBox odaSecimCmb;
        MusteriRezervasyon musteriRezervasyon;
        MusteriRezervasyonBLL _musteriRezervasyonBLL;
        TotalBLL _totalBLL;
        public Rezervasyon()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
            
            RCBLL = new RezervasyonCesidiBLL();
            RC = new RezervasyonCesidi();
            OBLL = new OdaCesidiBLL();
            OVCBLL = new OdaVeOdaCesidiBLL();
            _musteriRezervasyonBLL = new MusteriRezervasyonBLL();
            _totalBLL = new TotalBLL();
            _rezervasyonBLL = new RezervasyonBLL();


        }
        private void kisiSayisinaGoreDinamikRezervasyonBilgisiOlustur()
        {
            panelOdalar.Controls.Clear();
            eklenenOdalar = new List<ComboBox>();

            int acilacakOdaSayisi = (int)Math.Ceiling((double)KisiSayisi / 3.0);


            List<OdaCesidi> OC = OBLL.OdaCesitleriniGetir();

            int yukseklik = 24;

            for (int i = 0; i < acilacakOdaSayisi; i++)
            {
                odaSecimCmb = new ComboBox();
                odaSecimCmb.Width = 129;
                odaSecimCmb.Height = 24;
                List<OdaCesidi> cesitler = OBLL.OdaCesitleriniGetir();

                odaSecimCmb.DataSource = cesitler;
                odaSecimCmb.ValueMember = "OdaCesidiID";
                odaSecimCmb.DisplayMember = "Cesit";

                if (i != 0)
                {
                    odaSecimCmb.Location = new Point(0, yukseklik);
                    yukseklik += 24;

                }

                panelOdalar.Controls.Add(odaSecimCmb);
                eklenenOdalar.Add(odaSecimCmb);
            }
        }

        private void panelKisiBilgisiniGuncelle()
        {
            lblAd.Text = (musteriler.Count + 1) + ".Kişi Ad";
            lblSoyad.Text = (musteriler.Count + 1) + ".Kişi SoyAd";
            lblTc.Text = (musteriler.Count + 1) + ".Kişi Tc";

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTCKN.Text = "";
            txtTelefon.Text = "";

            int kisiSayisi = KisiSayisi;

            foreach (ComboBox item in eklenenOdalar)
            {
                if (item.SelectedItem.Equals("1 kişilik"))
                    kisiSayisi += 1;
                if (item.SelectedItem.Equals("2 kişilik"))
                    kisiSayisi += 2;
                if (item.SelectedItem.Equals("2+1kişilik"))
                    kisiSayisi += 3;
            }

            if (musteriler.Count >= kisiSayisi)
            {
                panelKisiBilgisi.Visible = false;
                btnRezervasyonOlustur.Enabled = false;
                btnTamamla.Visible = true;
            }
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            kisiSayisinaGoreDinamikRezervasyonBilgisiOlustur();
            List<RezervasyonCesidi> RCBLList = RCBLL.List();

            cmbRezCesidi.DataSource = RCBLList;
            cmbRezCesidi.ValueMember = "RezervasyonCesidiID";
            cmbRezCesidi.DisplayMember = "CesitAd";

        }

        private void btnRezervasyonOlustur_Click(object sender, EventArgs e)
        {
            panelKisiBilgisi.Visible = true;
            lblAd.Text = "1.Kişi Ad";
            lblSoyad.Text = "1.Kişi SoyAd";
            lblTc.Text = "1.Kişi Tc";
            lblTelefon.Text = "1.Kişi Telefon No";
        }

        private void btnSonrakiKisi_Click(object sender, EventArgs e)
        {
            if (txtTCKN.Text.Length != 11)
            {
                MessageBox.Show("TC 11 haneli olmalıdır.!");
                return;
            }

            Musteri m = new Musteri();
            m.Ad = txtAd.Text;
            m.Soyad = txtSoyad.Text;
            m.TcKimlikNo = txtTCKN.Text;
            m.TelefonNo = txtTelefon.Text;

            musteriler.Add(m);

            panelKisiBilgisiniGuncelle();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
           _musteriBLL = new MusteriBLL();
            _odaBLL = new OdaBLL();

            List<Oda> odalar = _odaBLL.List();
            List<int> BosOdalar = new List<int>();
            List<int> doluodalar = new List<int>();
            List<Entities.Rezervasyon> rezervasyonliste = _rezervasyonBLL.RezervasyonListesi();
       for (int i = 1; i < odalar.Count + 1; i++)
         {
                foreach (Entities.Rezervasyon item in rezervasyonliste)
               {
                    OdaVeOdaCesidi odaVeOdaCesidi = OVCBLL.IdileOdaVeOdaCesidiGetir(item.OdaveCesitID);
                    if ((dateTimePickerGiris.Value>=item.GirisTarihi && dateTimePickerGiris.Value<item.CikisTarihi) && odaVeOdaCesidi.OdaID==i)
                    {                      
                        doluodalar.Add(odaVeOdaCesidi.OdaID);
                        break;
                    }
                }                              
            }
            for (int j = 1; j < (odalar.Count + 1); j++)
            {
                if (doluodalar.Exists(element => element == j) != true)
                {
                    BosOdalar.Add(j);
                }
            }
            if (BosOdalar.Count == 0)
            {
                MessageBox.Show("Bu tarihlerde boş oda bulunmamaktadır.");
                return;
            }

            int rezCesitId = (int)cmbRezCesidi.SelectedValue;
            int odaCesidiId = (int)odaSecimCmb.SelectedValue;
            decimal RezCesitFiyati = RCBLL.GetMoneyById(rezCesitId);
            int ovcID = OVCBLL.OdaCesitleriniIDyeGoreGetir((int)odaSecimCmb.SelectedValue, BosOdalar[0]);
            decimal odaFiyati = OVCBLL.GetMoney(ovcID);
            

            Total total = new Total();
            total.OdaVeCesitID = ovcID;
            total.RezervasyonCesidiID = rezCesitId;
            //total.IndirimOrani = 30;
            total.OdaVeCesitIDFiyat = odaFiyati;
            total.RezervasyonCesidiIDFiyat = RezCesitFiyati;
            int count = 0;

            if (odaCesidiId==1) { total.IndirimOrani = 30; }
            else if (odaCesidiId==2) { total.IndirimOrani = 0; }
            else if (odaCesidiId == 7) { total.IndirimOrani = 20; }
            for (DateTime date = dateTimePickerGiris.Value; date <= dateTimePickerCikis.Value; date=date.AddDays(1))
            {
                if (date.DayOfWeek==DayOfWeek.Sunday || date.DayOfWeek==DayOfWeek.Saturday)
                {
                    count++;
                }
            }
            total.TotalFiyat = total.OdaVeCesitIDFiyat + total.RezervasyonCesidiIDFiyat + 30 * count;
            _totalBLL.Add(total);
            int ID = _totalBLL.SonTotal().TotalID;

            Entities.Rezervasyon rezervasyon = new Entities.Rezervasyon();
            rezervasyon.KisiSayisi = KisiSayisi;
            rezervasyon.GirisTarihi = dateTimePickerGiris.Value;
            rezervasyon.CikisTarihi = dateTimePickerCikis.Value;
            rezervasyon.RezervasyonCesidiID = rezCesitId;
            rezervasyon.OdaveCesitID = ovcID;
            rezervasyon.UyeID = frm_GirisEkrani.girisId;
            rezervasyon.TotalID = ID;
                 

            foreach (Musteri item in musteriler)
            {
                _musteriBLL.Add(item);
            }

            _rezervasyonBLL = new RezervasyonBLL();

            if(_rezervasyonBLL.Ekle(rezervasyon))
                MessageBox.Show("Rezervasyon Başarıyla Kaydedildi..");

            int sonmusteriID = _musteriBLL.SonMusteriID();
            int sonrezervasyonID = _rezervasyonBLL.SonRezervasyonID();

            for (int i = 0; i < musteriler.Count; i++)
            {
                _musteriRezervasyonBLL.Add(sonmusteriID-i, sonrezervasyonID);
            }

            musteriRezervasyon = new MusteriRezervasyon();
            musteriRezervasyon.RezervasyonID = rezervasyon.RezervasyonID;

            musteriler.Clear();

            this.Hide();
            RezervasyonBilgilerim rezervasyonBilgilerim = new RezervasyonBilgilerim();
            rezervasyonBilgilerim.FormClosing += RezervasyonBilgilerim_FormClosing;
            rezervasyonBilgilerim.Show();
            
        }

        private void RezervasyonBilgilerim_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KisiSayisi++;
            lblKisiSayisi.Text = KisiSayisi.ToString();

            kisiSayisinaGoreDinamikRezervasyonBilgisiOlustur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KisiSayisi--;
            lblKisiSayisi.Text = KisiSayisi.ToString();
        }

        private void PanelOdalar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

