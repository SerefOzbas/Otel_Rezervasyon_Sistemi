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
using MaterialSkin.Controls;
using MaterialSkin;

namespace UI
{
    public partial class frmRezCesidineGoreList : MaterialForm
    {
        Rezervasyon rez;
        RezervasyonCesidi RC;
        RezervasyonCesidiBLL RCBLL;
        OdaBLL odaBLL;
        YoneticiBLL yoneticiBLL;


        OdaCesidiBLL OdaCesidiBLL;
        public frmRezCesidineGoreList()
        {
            InitializeComponent();
            OdaCesidiBLL = new OdaCesidiBLL();
            RC = new RezervasyonCesidi();
            RCBLL = new RezervasyonCesidiBLL();
            OdaCesidiBLL = new OdaCesidiBLL();
            yoneticiBLL = new YoneticiBLL();
            rez = new Rezervasyon();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }
        
        public void ListeyiYazdir()
        {

            listView1.Items.Clear();
            List<Entities.Rezervasyon> rezervasyon = yoneticiBLL.RezervasyonCesidineGoreListele((int)cmbRezervasyonCes.SelectedValue);

            ListViewItem lvi;
            foreach (var item in rezervasyon)
            {
                lvi = new ListViewItem();
                lvi.Text = (item.GirisTarihi.ToString());
                lvi.SubItems.Add(item.CikisTarihi.ToString());
                lvi.SubItems.Add(item.KisiSayisi.ToString());
                lvi.SubItems.Add(item.Cesit.ToString());
                lvi.SubItems.Add(item.OdaID.ToString());
                listView1.Items.Add(lvi);

                lvi.Tag = item;
            }
        }

        private void BtnCesitEkle_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRezCesidiEkle frmekle = new frmRezCesidiEkle();
            frmekle.FormClosing += Frmekle_FormClosing; ;
            frmekle.ShowDialog();
        }

        private void Frmekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void BtnListele_Click_1(object sender, EventArgs e)
        {
            ListeyiYazdir();
        }

        private void FrmRezCesidineGoreList_Load_1(object sender, EventArgs e)
        {
            List<RezervasyonCesidi> RCBLList = RCBLL.List();

            cmbRezervasyonCes.DataSource = RCBLList;
            cmbRezervasyonCes.ValueMember = "RezervasyonCesidiID";
            cmbRezervasyonCes.DisplayMember = "CesitAd";
        }

       
    }
}

