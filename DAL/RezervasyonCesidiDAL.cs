using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace DAL
{
    public class RezervasyonCesidiDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public RezervasyonCesidiDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }

        public RezervasyonCesidi RezervasyonCesidiGosterID(int RezervasyonCesidiID)
        {
            cmd = new SqlCommand("Select * from RezervasyonCesidi where RezervasyonCesidiID=@RCID", cnn);

            cmd.Parameters.AddWithValue("@RCID", RezervasyonCesidiID);


            RezervasyonCesidi rc = null;


            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();


                rc = new RezervasyonCesidi()
                {
                    RezervasyonCesidiID = (int)reader["RezervasyonCesidiID"],
                    CesitAd = reader["CesitAd"].ToString(),
                    Aciklama = reader["Aciklama"].ToString(),
                    Fiyat = (int)reader["Fiyat"]



                };
                reader.Close();
                return rc;



            }
            catch (Exception)
            {

                return rc;
            }

            finally
            {
                cnn.Close();
            }
        }

        public List<RezervasyonCesidi> RezervasyonCesitleriniGoster()
        {
            cmd = new SqlCommand("Select * from RezervasyonCesidi",cnn);

            List<RezervasyonCesidi> RC = new List<RezervasyonCesidi>();


            try
            {
                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RC.Add(new RezervasyonCesidi()
                    {

                        RezervasyonCesidiID = (int)reader["rezervasyonCesidiID"],
                        CesitAd = reader["cesitAd"].ToString(),
                        Fiyat = (decimal)reader["fiyat"],
                        Aciklama = reader["aciklama"].ToString()

                    });

                }

                reader.Close();
                return RC;

            }
            catch (Exception)
            {

                return RC;
            }

            finally
            {

                cnn.Close();
            }
        }

        public decimal GetMoneyById(int rezCesitId)
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security = true");

            cmd = new SqlCommand("Select Fiyat from RezervasyonCesidi where RezervasyonCesidiID=@rcid", cnn);
            cmd.Parameters.AddWithValue("@rcid", rezCesitId);

            RezervasyonCesidi rezCesit = new RezervasyonCesidi();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                rezCesit.Fiyat = (decimal)rd["Fiyat"];
                return rezCesit.Fiyat;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

        public int AddRezervasyonCesit(RezervasyonCesidi rezervasyonCesidi)
        {


            cmd = new SqlCommand("insert into RezervasyonCesidi (CesitAd,Fiyat,Aciklama) values (@CesitAd,@Fiyat,@Aciklama)", cnn);

            cmd.Parameters.AddWithValue("@CesitAD", rezervasyonCesidi.CesitAd);
            cmd.Parameters.AddWithValue("@Fiyat", rezervasyonCesidi.Fiyat);
            cmd.Parameters.AddWithValue("@Aciklama", rezervasyonCesidi.Aciklama);
            return ExecuteCommand();

        }

        int ExecuteCommand()
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

    }
}
