using MaterialSkin;
using MaterialSkin.Controls;
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

namespace UI
{
    public partial class frmYoneticiAnaEkran : MaterialForm
    {
        RezervasyonBLL _rezervasyonBLL;
        OdaVeOdaCesidiBLL _odaVeOdaCesidiBLL;
        public frmYoneticiAnaEkran()
        {
           
            InitializeComponent();  
            _rezervasyonBLL = new RezervasyonBLL();
            _odaVeOdaCesidiBLL = new OdaVeOdaCesidiBLL();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYoneticiOda frmyonODa = new frmYoneticiOda();
            frmyonODa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Odalar frm_Odalar = new frm_Odalar();
            frm_Odalar.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e) //Musaitlik kontrolu
        {
            FrmYoneticiTariheGoreRezervasyon frmYoneticiTariheGore = new FrmYoneticiTariheGoreRezervasyon();
            frmYoneticiTariheGore.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmRezCesidineGoreList frmRezCesidineGoreList = new frmRezCesidineGoreList();
            frmRezCesidineGoreList.ShowDialog();
        }
       public static List<int> doluodarezervasyonlar ;
        private void FrmYoneticiAnaEkran_Load(object sender, EventArgs e)
        {
           
            List<Entities.Rezervasyon> rezervasyon = _rezervasyonBLL.RezervasyonListesi();
            ListViewItem lvi;
            foreach (var item in rezervasyon)
            {
                OdaVeOdaCesidi oda=_odaVeOdaCesidiBLL.IdileOdaVeOdaCesidiGetir(item.OdaveCesitID);
                lvi = new ListViewItem();
                lvi.Text = item.RezervasyonID.ToString();                
                lvi.SubItems.Add(item.GirisTarihi.ToString());
                lvi.SubItems.Add(item.CikisTarihi.ToString());
                lvi.SubItems.Add(oda.OdaID.ToString());
                lvi.SubItems.Add(item.KisiSayisi.ToString() + " kişilik oda");
                lvi.Tag = item;

                if (item.GirisTarihi<=DateTime.Now.Date && item.CikisTarihi>DateTime.Now.Date)
                {
                    doluodarezervasyonlar = new List<int>();
                    listView1.Items.Add(lvi);
                    doluodarezervasyonlar.Add(oda.OdaID);
                }
               
            }
        }
    }
}
