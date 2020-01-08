using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class YoneticiDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public YoneticiDAL()
        {

           // cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }
        public List<Yonetici> GetAllYonetici()
        {
            cmd = new SqlCommand("select *from Yonetici" , cnn);
            List<Yonetici> yonetici = new List<Yonetici>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader
                (System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    yonetici.Add(new Yonetici()
                    {

                        YoneticiID = (int)reader["YoneticiID"],
                       UyeID=(int)reader["UyeID"],
                       RezervasyonCesidiID=(int)reader["RezervasyonCesidiID"],
                       OdaVeCesitID=(int)reader["OdaVeCesidiID"],
                       MusteriRezID=(int)reader["MusteriRezID"],
                       TotalID=(int)reader["TotalID"]
                    });

                }
                reader.Close();

                return yonetici;
            }
            catch (Exception)
            {

                return yonetici;
            }

        }

        public Yonetici GetYoneticiByID(int YoneticiID)
        {
            cmd = new SqlCommand("select * from Yonetici where YoneticiID=@yoneticiID", cnn);

            cmd.Parameters.AddWithValue("@YoneticiID", YoneticiID);
            Yonetici yonetici = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                yonetici = new Yonetici()
                {

                    YoneticiID = (int)reader["YoneticiID"],
                    UyeID = (int)reader["UyeID"],
                    RezervasyonCesidiID = (int)reader["RezervasyonCesidiID"],
                    OdaVeCesitID = (int)reader["OdaVeCesidiID"],
                    MusteriRezID = (int)reader["MusteriRezID"],
                    TotalID = (int)reader["TotalID"]

                };
                reader.Close();
                return yonetici;
            }
            catch (Exception)
            {

                return yonetici;
            }
            finally
            {
                cnn.Close();
            }

        }

        public List<Rezervasyon> RezervasyonCesidiIleListele(int rezervasyonCesidiID)
        {
            cmd = new SqlCommand("select RezervasyonCesidiID,GirisTarihi,CikisTarihi,KisiSayisi,oc.Cesit,o.OdaID from Rezervasyon as r join OdaVeOdaCesidi ovc on r.OdaVeCesitID=ovc.OdaVeCesitID join OdaCesidi oc on ovc.OdaCesidiID=oc.OdaCesidiID join Oda o on ovc.OdaID=o.OdaID where RezervasyonCesidiID=@RezervasyonCesidiID", cnn);
            cmd.Parameters.AddWithValue("@RezervasyonCesidiID", rezervasyonCesidiID);

            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);              
                while (rd.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {

                        OdaID = (int)rd["OdaID"],
                        GirisTarihi = (DateTime)rd["GirisTarihi"],
                        CikisTarihi = (DateTime)rd["CikisTarihi"],
                        KisiSayisi = (int)rd["KisiSayisi"],
                        Cesit = rd["Cesit"].ToString()

                    });
                }
                rd.Close();
                return rezervasyonlar;
            }
            catch (Exception ex)
            {
                return rezervasyonlar;
            }
            finally
            {
                cnn.Close();
            }
        }


    }
}
