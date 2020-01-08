using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class MusteriDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public MusteriDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH;database=OtelRezervasyon;Integrated Security=true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }

        public int GetSonMusteriId()
        {
            cmd = new SqlCommand("select top 1 MusteriID from Musteri order by MusteriID desc", cnn);
            Musteri musteri = new Musteri();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();

                musteri.MusteriID = (int)rd["MusteriID"];

                rd.Close();
                return musteri.MusteriID;
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
        public int AddMusteri(Musteri musteri)
        {
            cmd = new SqlCommand("insert into Musteri (Ad,Soyad,TCKN,TelefonNo) values (@Ad,@Soyad,@TcKimlikNo,@TelefonNo)", cnn);
            cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
            cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
            cmd.Parameters.AddWithValue("@TcKimlikNo", musteri.TcKimlikNo);
            cmd.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);



            return ExecuteCommand();
        }
        public int UpdateMusteri(Musteri musteri)
        {
            cmd = new SqlCommand("update Musteri set Ad=@Ad,Soyad=@Soyad,TcKimlikNo=@TcKimlikNo,TelefonNo=@TelefonNo where MusteriID=@MusteriID", cnn);
            cmd.Parameters.AddWithValue("@Ad", musteri.Ad);
            cmd.Parameters.AddWithValue("@Soyad", musteri.Soyad);
            cmd.Parameters.AddWithValue("@TcKimlikNo", musteri.TcKimlikNo);
            cmd.Parameters.AddWithValue("@TelefonNo", musteri.TelefonNo);


            cmd.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);

            return ExecuteCommand();

        }

        public int DeleteMusteri(Musteri musteri)
        {
            cmd = new SqlCommand("Delete from Musteri where MusteriID=@MusteriID", cnn);
            cmd.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
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
       
        public List<Musteri> GetAllMusteri()
        {
            cmd = new SqlCommand("select * from Musteri", cnn);
            List<Musteri> musteri = new List<Musteri>();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {

                    musteri.Add(new Musteri()
                    {
                        MusteriID = (int)rd["musteriId"],
                        Ad = rd["ad"].ToString(),
                        Soyad = rd["soyad"].ToString(),
                        TcKimlikNo = rd["TCKN"].ToString(),
                        TelefonNo = rd["TelefonNo"].ToString()
                    });

                }
                rd.Close();

                return musteri;
            }
            catch (Exception)
            {
                return musteri;
            }

        }

        public Musteri GetMusterisById(int musterlId)
        {
            cmd = new SqlCommand("select * from Musteri where MusteriID =@MusteriID ",cnn);
            cmd.Parameters.AddWithValue("@MusteriID", musterlId);
            Musteri musteri = null;
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                musteri = new Musteri()
                {
                    MusteriID = (int)rd["musteriId"],
                    Ad = rd["ad"].ToString(),
                    Soyad = rd["soyad"].ToString(),
                    TcKimlikNo = rd["TCKN"].ToString(),
                    TelefonNo = rd["TelefonNo"].ToString()
                };
                rd.Close();
                return musteri;



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
