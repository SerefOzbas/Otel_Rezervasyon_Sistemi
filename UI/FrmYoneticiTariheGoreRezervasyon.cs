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
    public partial class FrmYoneticiTariheGoreRezervasyon : MaterialForm
    {
        RezervasyonBLL _rezervasyonBLL;
        OdaVeOdaCesidiBLL _odaVeOdaCesidiBLL;
        OdaBLL _odaBLL;
        MusteriRezervasyonBLL _musteriRezervasyonBLL;
        MusteriBLL _musteriBLL;
        public FrmYoneticiTariheGoreRezervasyon()
        {
            InitializeComponent();
            _rezervasyonBLL = new RezervasyonBLL();
            _odaVeOdaCesidiBLL = new OdaVeOdaCesidiBLL();
            _odaBLL = new OdaBLL();
            _musteriRezervasyonBLL = new MusteriRezervasyonBLL();
            _musteriBLL = new MusteriBLL();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }

        public static List<Musteri> musteri;
        List<int> doluodalar;
        private void Btnlistele_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView1.Visible = true;
            listView2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            doluodalar = new List<int>();
            List<Entities.Rezervasyon> rezervasyon = _rezervasyonBLL.RezervasyonListesi();
            List<Oda> odalar = _odaBLL.List();

            for (int i = 1; i < (odalar.Count + 1); i++)
            {
                foreach (var item in rezervasyon)
                {
                    item.OdaID = _odaVeOdaCesidiBLL.IdileOdaVeOdaCesidiGetir(item.OdaveCesitID).OdaID;
                    if (item.GirisTarihi >= dateTimePicker1.Value && item.GirisTarihi < dateTimePicker2.Value && item.OdaID == i)
                    {
                        ListViewItem lstItem = new ListViewItem(i.ToString());
                        lstItem.Tag = item;
                        listView2.Items.Add(lstItem);
                        doluodalar.Add(i);
                    }                 
                }             
            }
           
            for (int j = 1; j < (odalar.Count + 1); j++)
            {
                if (doluodalar.Exists(element=>element==j)!=true)
                {
                    listView1.Items.Add(j.ToString());
                }              
            }
        }

        

        private void ListView2_DoubleClick(object sender, EventArgs e)
        {
            List<MusteriRezervasyon> rezervasyonlar = _musteriRezervasyonBLL.GetTumMusteriRezervasyon();
            List<Musteri> musteriler = _musteriBLL.List();
            Entities.Rezervasyon rezervasyon = (Entities.Rezervasyon)listView2.FocusedItem.Tag;
            List<MusteriRezervasyon> musterirezervasyon = new List<MusteriRezervasyon>();
            for (int i = 0; i < rezervasyonlar.Count; i++)
            {
                if (rezervasyonlar[i].RezervasyonID == rezervasyon.RezervasyonID)
                {
                    musterirezervasyon.Add(_musteriRezervasyonBLL.GetMusteriRezervasyon(rezervasyon.RezervasyonID));
                }
            }
            musteri = new List<Musteri>();
            for (int i = 0; i < musterirezervasyon.Count; i++)
            {
                for (int j = 0; j < musteriler.Count; j++)
                {
                    if (musteriler[j].MusteriID == musterirezervasyon[i].MusteriID)
                    {
                        musteri.Add(_musteriBLL.GetMusteri(musterirezervasyon[i].MusteriID));
                    }

                }
            }
            DoluOdaMusteri musteriform = new DoluOdaMusteri();
            musteriform.ShowDialog();
        }

       
    }
}

