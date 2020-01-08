using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
    public class MusteriRezervasyonDAL
    {
        //SqlConnection cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH;database=OtelRezervasyon;Integrated Security=true");
        SqlConnection cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        SqlCommand cmd;
        public int MusteriRezervasyonSil(Entities.Rezervasyon rezervasyon)
        {
            cmd = new SqlCommand("delete from MusteriRezervasyon where RezervasyonID=@rezId", cnn);
            cmd.Parameters.AddWithValue("@rezId", rezervasyon.RezervasyonID);

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

        public MusteriRezervasyon GetMusteriRezervasyonId(int rezervasyonId)
        {
            cmd = new SqlCommand("select * from MusteriRezervasyon where RezervasyonID=@RezervasyonID", cnn);
            cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonId);
            MusteriRezervasyon musteriRezervasyon = null;
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                musteriRezervasyon = new MusteriRezervasyon()
                {
                    RezervasyonID = (int)rd["RezervasyonID"],
                    MusteriID = (int)rd["MusteriID"],
                    MusteriRez = (int)rd["MusteriRezID"]

                };
                rd.Close();
                return musteriRezervasyon;



            }
            catch (Exception hata)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }
        public MusteriRezervasyon GetRezervasyonId(int MusteriID)
        {
            cmd = new SqlCommand("select * from MusteriRezervasyon where MusteriID =@MusteriID ", cnn);
            cmd.Parameters.AddWithValue("@MusteriID", MusteriID);
            MusteriRezervasyon musteriRezervasyon = null;
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                musteriRezervasyon = new MusteriRezervasyon()
                {
                    RezervasyonID = (int)rd["RezervasyonID"],
                    MusteriID = (int)rd["MusteriID"],
                    MusteriRez = (int)rd["MusteriRezID"]

                };
                rd.Close();
                return musteriRezervasyon;



            }
            catch (Exception hata)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }
        public List<MusteriRezervasyon> GetMusteriRezervasyon()
        {
            cmd = new SqlCommand("select * from MusteriRezervasyon", cnn);
            List<MusteriRezervasyon> musteriRezervasyon = new List<MusteriRezervasyon>();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    musteriRezervasyon.Add(new MusteriRezervasyon()
                    {
                        RezervasyonID = (int)rd["RezervasyonID"],
                        MusteriID = (int)rd["MusteriID"],
                        MusteriRez = (int)rd["MusteriRezID"]

                    });
                }
                rd.Close();
                return musteriRezervasyon;

            }
            catch (Exception hata)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }

        public int Add(int musteriID,int rezervasyonID)
        {
            cmd = new SqlCommand("insert into MusteriRezervasyon (RezervasyonID,MusteriID) values (@RezervasyonID,@MusteriID)", cnn);
            cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonID);
            cmd.Parameters.AddWithValue("@MusteriID",musteriID);
            
            return ExecuteCommand();
        }
    }
}
