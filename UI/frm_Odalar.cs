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
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace UI
{
    public partial class frm_Odalar : MaterialForm
    {
        SqlConnection cnn;
        OdaBLL _odaBLL;
        ///SqlCommand cmd;
        public frm_Odalar()
        {
            InitializeComponent();
            //cnn = new SqlConnection("server=DESKTOP-UGHD8MH;database=OtelRezervasyon;Integrated Security=true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
            _odaBLL = new OdaBLL();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }
        DataTable dt;
        SqlDataAdapter da;
        List<Oda> odalarson;
        private void frm_Odalar_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from oda", cnn);
            dt = new DataTable();
            da.Fill(dt);
            List<int> rezervasyonid = frmYoneticiAnaEkran.doluodarezervasyonlar;
            List<Oda> odalar = new List<Oda>();

            foreach (Oda item in odalar)
            {
                if (rezervasyonid.Exists(element => element == item.OdaID) == true)
                {
                    item.Doluluk = true;
                   
                }
                else
                {
                    item.Doluluk = false;
                }
                _odaBLL.Update(item);
            }
            odalarson = _odaBLL.List();
            dataGridView1.DataSource = dt;
            dataGridView1.Tag = dt.Rows[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commBuilder = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Güncelleme başarıyla gerçekleşmiştir.");
            this.Close();
        }

    }
}
