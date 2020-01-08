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
    public partial class frm_KayitEkrani : MaterialForm
    {
        UyeBLL _uyeBLL;
        public frm_KayitEkrani()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            _uyeBLL = new UyeBLL();

            Uye uye = new Uye(){
                Mail = txtKA.Text,
                Sifre = txtSifre.Text
            };

            if(_uyeBLL.Add(uye))
            {
                MessageBox.Show("Başarıyla Kaydedildi.");
                this.Close();
            }
               
        }
    }
}
