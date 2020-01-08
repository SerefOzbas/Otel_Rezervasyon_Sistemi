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
    public partial class frmRezCesidiEkle : MaterialForm
    {
        RezervasyonCesidiBLL RCBLL;
        public frmRezCesidiEkle()
        {
            InitializeComponent();
            RCBLL = new RezervasyonCesidiBLL();

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            RezervasyonCesidi RC = new RezervasyonCesidi();
            RC.CesitAd = txtAd.Text;
            RC.Fiyat = int.Parse(txtFiyat.Text);
            RC.Aciklama = txtAciklama.Text;


            if (RCBLL.Add(RC))
            {
                this.Hide();
                MessageBox.Show("Rezervasyon Çeşidi Başarıyla Eklendi");
                frmRezCesidineGoreList frmRezCesidineGoreList = new frmRezCesidineGoreList();
                frmRezCesidineGoreList.FormClosing += FrmRezCesidineGoreList_FormClosing; ;
                frmRezCesidineGoreList.ShowDialog();

            }

        }

        private void FrmRezCesidineGoreList_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Close();
        }
    }
}
