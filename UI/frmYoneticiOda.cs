using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace UI
{
    public partial class frmYoneticiOda : MaterialForm
    {
        OdaCesidiBLL _OdaCesidiBLL;
        OdaCesidi odaCesidi;
        DataTable dt;
        SqlDataAdapter da;
        SqlConnection cnn;

        public frmYoneticiOda()
        {
            InitializeComponent();
            _OdaCesidiBLL = new OdaCesidiBLL();
            //cnn = new SqlConnection("server=DESKTOP-UGHD8MH;database=OtelRezervasyon;Integrated Security=true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Green300, Primary.BlueGrey500, Accent.Yellow400, TextShade.BLACK);
        }
        void OdaCesitleriniYazdir()
        {
            da = new SqlDataAdapter("select * from odacesidi", cnn);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Tag = dt.Rows[0];
        }

        private void frmYoneticiOda_Load(object sender, EventArgs e)
        {
           OdaCesitleriniYazdir();
        }

        public void Guncelle()
        {
            odaCesidi = new OdaCesidi();
            SqlCommandBuilder commBuilder = new SqlCommandBuilder(da);
            da.Update(dt);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
    }
}
