using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
    public class OdaDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public OdaDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }

        public int AddOda(Oda oda)
        {
            cmd = new SqlCommand("insert into Oda (Doluluk,Fiyati) values (@Doluluk,@Fiyati)", cnn);
       
            cmd.Parameters.AddWithValue("@Doluluk", oda.Doluluk);
            cmd.Parameters.AddWithValue("@Fiyati", oda.Fiyat);
            return ExecuteCommand();
        }
        public int UpdateOda(Oda oda)
        {
            cmd = new SqlCommand("update Oda set Doluluk=@Doluluk,Fiyati=@Fiyati where OdaID=@OdaID", cnn);
       
            cmd.Parameters.AddWithValue("@Doluluk", oda.Doluluk);
            cmd.Parameters.AddWithValue("@Fiyati", oda.Fiyat);
            cmd.Parameters.AddWithValue("@OdaID", oda.OdaID);

            return ExecuteCommand();

        }
        public int DeleteOda(Oda oda)
        {
            cmd = new SqlCommand("Delete from Oda where OdaID=@OdaID", cnn);
            cmd.Parameters.AddWithValue("@OdaID", oda.OdaID);
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

        public List<Oda> GetAllOda()
        {
            cmd = new SqlCommand("select * from  Oda", cnn);
            List<Oda> oda = new List<Oda>();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {

                    oda.Add(new Oda()
                    {
                        OdaID = (int)rd["OdaID"],                 
                        Doluluk = (Boolean)rd["Doluluk"],
                        Fiyat = (decimal)rd["Fiyati"]

                    });

                }
                rd.Close();

                return oda;
            }
            catch (Exception)
            {
                return oda;
            }

        }
        public int SilUpdateOda(Rezervasyon rezervasyon)
        {
            cmd = new SqlCommand("update Oda set Doluluk=0 where OdaID=@OdaID", cnn);
            cmd.Parameters.AddWithValue("@OdaID", rezervasyon.OdaID);
      
        //    cmd.Parameters.AddWithValue("@Fiyat", musteri.Fiyat);
            return ExecuteCommand();

        }

        public Oda GetOdaById(int odaId)
        {
            cmd = new SqlCommand("select * from oda where OdaID=@OdaID",cnn);
            cmd.Parameters.AddWithValue("@OdaID", odaId);
            Oda oda = null;
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                oda = new Oda()
                {
                    OdaID = (int)rd["OdaID"],
                    
                    Doluluk = (Boolean)rd["Doluluk"],
                   // Fiyat = (decimal)rd["Fiyat"]
                };
                rd.Close();
                return oda;



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

    }
}
