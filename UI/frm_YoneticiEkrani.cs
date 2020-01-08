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
    public partial class frm_YoneticiEkrani : Form
    {
        YoneticiBLL _yoneticiBLL;
        public frm_YoneticiEkrani()
        {
            InitializeComponent();
            _yoneticiBLL = new YoneticiBLL();
        }

        private void Frm_ListDoldur()
        {
            listView1.Items.Clear();

            List<Yonetici> yonetici = _yoneticiBLL.List();

            ListViewItem lvi;
            foreach (var item in yonetici)
            {
                lvi = new ListViewItem();
                lvi.Text = item.YoneticiID.ToString();
                lvi.SubItems.Add(item.Ad_Soyad);
                lvi.SubItems.Add(item.Cesit);
                lvi.SubItems.Add(item.CesitAd);
               lvi.SubItems.Add(item.Fiyat.ToString());
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }

        }

        private void Frm_YoneticiEkrani_Load(object sender, EventArgs e)
        {
            Frm_ListDoldur();
        }
    }
}
