using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class UyeDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;


        public UyeDAL()
        {

           // cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }
        public int AddUye(Uye uye)
        {
            cmd = new SqlCommand("insert into Uye (Mail,Sifre) values (@mail,@sifre)", cnn);
            cmd.Parameters.AddWithValue("@mail", uye.Mail);
            cmd.Parameters.AddWithValue("@sifre", uye.Sifre);
            return ExeCuteCommand();
        }
        public int UpdateUye(Uye uye)
        {
            cmd = new SqlCommand("update Uye set Mail=@mail,Sifre=@sifre where UyeID=@uyeID", cnn);
            cmd.Parameters.AddWithValue("@mail", uye.Mail);
            cmd.Parameters.AddWithValue("@sifre", uye.Sifre);
            cmd.Parameters.AddWithValue("@uyeID", uye.UyeID);
            return ExeCuteCommand();

        }

        public int DeleteUye(Uye uye)
        {
            cmd = new SqlCommand("delete from Uye where UyeID=@uyeID", cnn);
            cmd.Parameters.AddWithValue("@uyeID", uye.UyeID);
            return ExeCuteCommand();
        }

        int ExeCuteCommand()
        {
            try
            {
                cnn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {

                cnn.Close();

            }
        }

        public List<Uye> GetAllUye()
        {
            cmd = new SqlCommand("select * from Uye", cnn);
            List<Uye> uye = new List<Uye>();
            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader
                (System.Data.CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    uye.Add(new Uye()
                    {

                        UyeID = (int)reader["UyeID"],
                        Mail = reader["Mail"].ToString(),
                        Sifre = reader["Sifre"].ToString()
                    });

                }
                reader.Close();

                return uye;
            }
            catch (Exception)
            {

                return uye;
            }

        }


        public Uye GetUyeByID(int uyeID)
        {
            cmd = new SqlCommand("select * from Uye where UyeID=@uyeId", cnn);
            cmd.Parameters.AddWithValue("@uyeId", uyeID);
            Uye uye = null;

            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                uye = new Uye()
                {
                    UyeID = (int)reader["uyeId"],
                    Mail = reader["mail"].ToString(),
                    Sifre = reader["sifre"].ToString()
                };
                reader.Close();
                return uye;
            }
            catch (Exception)
            {
                return uye;
            }
            finally
            {
                cnn.Close();
            }

        }

        public List<Rezervasyon> GetRezervasyonBilgileriByID(int uyeID)
        {
            cmd = new SqlCommand("select* from Rezervasyon where UyeID=@UyeID", cnn);
            cmd.Parameters.AddWithValue("@UyeID", uyeID);
            List<Rezervasyon> uye = new List<Rezervasyon>();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {

                    uye.Add(new Rezervasyon()
                    {
                       


                        RezervasyonID = (int)rd["rezervasyonid"],
                        GirisTarihi = (DateTime)rd["giristarihi"],
                        CikisTarihi = (DateTime)rd["cikistarihi"],
                        KisiSayisi = (int)rd["KisiSayisi"],
                        RezervasyonCesidiID = (int)rd["rezervasyoncesidiid"],
                        OdaveCesitID = (int)rd["OdaVeCesitID"],
                        UyeID = (int)rd["UyeID"],
                        TotalID = (int)rd["TotalID"]

                    });

                }
                rd.Close();
                return uye;
            }
            catch (Exception)
            {
                return uye;
            }

        }
    }
}
