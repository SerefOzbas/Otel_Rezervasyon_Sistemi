using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class TotalDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;

        public TotalDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }

        public List<Total> TotalCesitleriniGoster()
        {
            cmd = new SqlCommand("Select * from Total ");

            List<Total> total = new List<Total>();


            try
            {

                cnn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    total.Add(new Total()
                    {

                        TotalID = (int)reader["TotalID"],
                        OdaVeCesitID = (int)reader["OdaVeCesitID"],
                        RezervasyonCesidiID = (int)reader["RezervastonCesidiID"],
                        IndirimOrani = (int)reader["IndirimOrani"],
                        TotalFiyat = (decimal)reader["TotalFiyat"]



                    });


                }

                reader.Close();
                return total;

            }
            catch (Exception)
            {

                return total;
            }

            finally
            {

                cnn.Close();
            }
        }

        public int TotalEkle(Total total)
        {
           
            cmd = new SqlCommand("insert into Total (OdaVeCesitID,RezervasyonCesidiID,IndirimOrani,TotalFiyat) values (@OdaVeCesitID,@RezervasyonCesidiID,@IndirimOrani,@TotalFiyat);select SCOPE_IDENTITY() as TotalID;", cnn);
            cmd.Parameters.AddWithValue("@OdaVeCesitID", total.OdaVeCesitID);          
            cmd.Parameters.AddWithValue("@RezervasyonCesidiID", total.RezervasyonCesidiID);    cmd.Parameters.AddWithValue("@IndirimOrani", total.IndirimOrani);
            cmd.Parameters.AddWithValue("@TotalFiyat",total.TotalFiyat);          
            try
            {
                cnn.Open();
                
             return cmd.ExecuteNonQuery();  
                
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                cnn.Close();
            }
        }
       
        public Total GetSonTotalId()
        {
            cmd = new SqlCommand("select top 1 * from Total order by TotalID desc", cnn);          
            Total sontotal = new Total();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                //sontotal = new Total()
                //{
                sontotal.OdaVeCesitID = (int)rd["OdaVeCesitID"];
                sontotal.RezervasyonCesidiID = (int)rd["RezervasyonCesidiID"];
                sontotal.IndirimOrani =(int)(rd["IndirimOrani"]);
                sontotal.TotalID = (int)rd["TotalID"];
                sontotal.TotalFiyat = (decimal)rd["TotalFiyat"];

                //};
                rd.Close();
                return sontotal;



            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

    }
}
