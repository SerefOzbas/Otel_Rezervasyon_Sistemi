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
    public partial class DoluOdaMusteri : MaterialForm

    {
        MusteriRezervasyonBLL _musteriRezervasyonBLL;
        RezervasyonBLL _rezervasyonBLL;
        public DoluOdaMusteri()
        {
            InitializeComponent();
            _musteriRezervasyonBLL = new MusteriRezervasyonBLL();
            _rezervasyonBLL = new RezervasyonBLL();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }
        private void DoluOdaMusteri_Load_1(object sender, EventArgs e)
        {
            ListViewItem lvi;
            foreach (var item in FrmYoneticiTariheGoreRezervasyon.musteri)
            {
                lvi = new ListViewItem();
                lvi.Text = item.Ad.ToString();
                lvi.SubItems.Add(item.Soyad.ToString());
                lvi.SubItems.Add(item.TcKimlikNo.ToString());
                lvi.SubItems.Add(item.TelefonNo.ToString());
                lvi.SubItems.Add(_rezervasyonBLL.RezervasyonGetir(_musteriRezervasyonBLL.GetRezervasyon(item.MusteriID).RezervasyonID).GirisTarihi.ToString());
                lvi.SubItems.Add(_rezervasyonBLL.RezervasyonGetir(_musteriRezervasyonBLL.GetRezervasyon(item.MusteriID).RezervasyonID).CikisTarihi.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);
                
            }

        }

        
    }
}
