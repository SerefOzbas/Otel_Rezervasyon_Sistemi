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
    public partial class frm_GirisEkrani : Form
    {
        UyeBLL _uyeBLL;
        frmYoneticiAnaEkran frmYonAn;
        public frm_GirisEkrani()
        {
            InitializeComponent();
        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            frm_KayitEkrani frm_KayitEkrani = new frm_KayitEkrani();               
            frm_KayitEkrani.ShowDialog();
           
        }

        List<Uye> uyeler = new List<Uye>();
        public static int girisId;

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            _uyeBLL = new UyeBLL();
           
            List<Uye> uyeler = new List<Uye>();
            uyeler = _uyeBLL.List();

            foreach (Uye item in uyeler)
            {
                if (txtKA.Text == "furkan" && txtSifre.Text == "12345678")
                {
                    this.Hide();
                    frmYonAn = new frmYoneticiAnaEkran();
                    frmYonAn.FormClosing += FrmYonAn_FormClosing; 
                    frmYonAn.ShowDialog();
                    return;
                }
                else if (item.Mail == txtKA.Text && item.Sifre == txtSifre.Text)
                {
                    this.Hide();
                    girisId = item.UyeID;
                    //MessageBox.Show("Giriş Yapıldı.!");
                    RezervasyonBilgilerim rezervasyonBilgilerim = new RezervasyonBilgilerim();
                    rezervasyonBilgilerim.FormClosing += RezervasyonBilgilerim_FormClosing;
                    rezervasyonBilgilerim.Show();
                    return;
                }
                
            }
            MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı.!");
        }

        private void RezervasyonBilgilerim_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Close();
        }

        private void FrmYonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
           this.Close();
        }

        
    }
}
