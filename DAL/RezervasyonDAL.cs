using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class RezervasyonDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public RezervasyonDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        }

        /// <summary>
        /// //Tüm Rezervasyonlari Getirir.
        /// </summary>
        /// <returns></returns>
        public List<Rezervasyon> RezervasyonKayitlariniGetir() 
        {
            cmd = new SqlCommand("select * from Rezervasyon",cnn);

            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {
                        RezervasyonID = (int)rd["RezervasyonID"],
                        GirisTarihi = (DateTime)rd["giristarihi"],
                        CikisTarihi = (DateTime)rd["cikistarihi"],
                        KisiSayisi= (int)rd["KisiSayisi"],
                        RezervasyonCesidiID = (int)rd["RezervasyonCesidiID"],
                        OdaveCesitID=(int)rd["OdaVeCesitID"],
                      UyeID = (int)rd["UyeID"],
                     //TotalID=(int)rd["TotalID"]
                        
                    });
                }
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

        /// <summary>
        /// //ID'ye göre rezervasyon bilgilerini getirir.
        /// </summary>
        /// <returns></returns>
        public Rezervasyon IDyeGoreRezervasyonGetir(int rezervasyonId) 
        {
            cmd = new SqlCommand("select * from Rezervasyon where RezervasyonID=@RezervasyonID", cnn);

            cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonId);

            Rezervasyon rezervasyon = new Rezervasyon();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {

                    rezervasyon.RezervasyonID = (int)rd["RezervasyonID"];
                    rezervasyon.GirisTarihi = (DateTime)rd["giristarihi"];
                    rezervasyon.CikisTarihi = (DateTime)rd["cikistarihi"];
                    rezervasyon.KisiSayisi = (int)rd["KisiSayisi"];
                    rezervasyon.RezervasyonCesidiID = (int)rd["RezervasyonCesidiID"];
                    rezervasyon.OdaveCesitID = (int)rd["OdaVeCesitID"];
                    rezervasyon.UyeID = (int)rd["UyeID"];
                    //rezervasyon.TotalID = (int)rd["TotalID"];
                    
                }
                return rezervasyon;
            }
            catch (Exception hata)
            {
                return rezervasyon;
            }
            finally
            {
                cnn.Close();
            }
            
        }

        /// <summary>
        /// Yeni bir rezervasyon ekler.
        /// </summary>
        /// <param name="rezervasyon"></param>
        /// <returns></returns>
        public int RezervasyonEkle(Rezervasyon rezervasyon)
        {
            cmd = new SqlCommand("insert into Rezervasyon (GirisTarihi, CikisTarihi,KisiSayisi, RezervasyonCesidiID, OdaVeCesitID, UyeID,TotalID) values (@GirisTarihi, @CikisTarihi,@KisiSayisi, @RezervasyonCesidiID, @OdaVeCesitID, @UyeID,@TotalID)", cnn);
            cmd.Parameters.AddWithValue("@GirisTarihi", rezervasyon.GirisTarihi);
            cmd.Parameters.AddWithValue("@CikisTarihi", rezervasyon.CikisTarihi);
            cmd.Parameters.AddWithValue("@KisiSayisi", rezervasyon.KisiSayisi);
            cmd.Parameters.AddWithValue("@RezervasyonCesidiID", rezervasyon.RezervasyonCesidiID);
            cmd.Parameters.AddWithValue("@OdaveCesitID", rezervasyon.OdaveCesitID);
            cmd.Parameters.AddWithValue("@UyeID", rezervasyon.UyeID);
            cmd.Parameters.AddWithValue("@TotalID",rezervasyon.TotalID);

            return ExecuteCommand();
        }

        /// <summary>
        /// Var olan rezervasyonu günceller.
        /// </summary>
        /// <param name="rezervasyon"></param>
        /// <returns></returns>
        public int RezervasyonGuncelle(Rezervasyon rezervasyon)
        {
            cmd = new SqlCommand("update rezervasyon set GirisTarihi=@GirisTarihi, CikisTarihi=@CikisTarihi,KisiSayisi=@KisiSayisi, RezervasyonCesidiID=@RezervasyonCesidiID, OdaVeCesitID=@OdaVeCesitID, UyeID=@UyeID, TotalID=@TotalID where RezervasyonID=@RezervasyonID", cnn);

            cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyon.RezervasyonID);
            cmd.Parameters.AddWithValue("@GirisTarihi", rezervasyon.GirisTarihi);
            cmd.Parameters.AddWithValue("@CikisTarihi", rezervasyon.CikisTarihi);
            cmd.Parameters.AddWithValue("@KisiSayisi", rezervasyon.KisiSayisi);
            cmd.Parameters.AddWithValue("@RezervasyonCesidiID", rezervasyon.RezervasyonCesidiID);
            cmd.Parameters.AddWithValue("@OdaVeCesitID", rezervasyon.OdaveCesitID);
            cmd.Parameters.AddWithValue("@UyeID", rezervasyon.UyeID);
            cmd.Parameters.AddWithValue("@TotalID", rezervasyon.TotalID);

            return ExecuteCommand();
        }

        /// <summary>
        /// İptal edilen rezervasyonu siler.
        /// </summary>
        /// <param name="rezervasyon"></param>
        /// <returns></returns>
        public int RezervasyonSil(Entities.Rezervasyon rezervasyon)
        {
            cmd = new SqlCommand("delete from rezervasyon where RezervasyonID=@rezId", cnn);
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


        public Rezervasyon UyeIDyeGoreRezervasyonGetir(int UyeID)
        {
            cmd = new SqlCommand("select  * from rezervasyon where UyeID=@UyeID", cnn);

            cmd.Parameters.AddWithValue("@UyeID", UyeID);

            Rezervasyon rezervasyon = null;

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    rezervasyon = new Rezervasyon()
                    {
                        RezervasyonID = (int)rd["rezervasyonid"],
                        GirisTarihi = (DateTime)rd["giristarihi"],
                        CikisTarihi = (DateTime)rd["cikistarihi"],
                        KisiSayisi=(int)rd["KisiSayisi"],
                        RezervasyonCesidiID=(int)rd["RezervasyonCesidi"],
                        OdaveCesitID=(int)rd["OdaVeCesit"],
                        UyeID=(int)rd["UyeID"],
                        TotalID=(int)rd["TotalID"]
                       
                    };
                }
                return rezervasyon;
            }
            catch (Exception)
            {
                return rezervasyon;
            }
            finally
            {
                cnn.Close();
            }

        }

        public Rezervasyon MusteriIDyeGoreRezervasyonGetir(int MusteriID)
        {
            cmd = new SqlCommand("select  * from rezervasyon where MusteriID=@MusteriID", cnn);

            cmd.Parameters.AddWithValue("@MusteriID", MusteriID);

            Rezervasyon rezervasyon = null;

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    rezervasyon = new Rezervasyon()
                    {
                        RezervasyonID = (int)rd["rezervasyonid"],
                        GirisTarihi = (DateTime)rd["giristarihi"],
                        CikisTarihi = (DateTime)rd["cikistarihi"],
                        KisiSayisi = (int)rd["KisiSayisi"],
                        RezervasyonCesidiID = (int)rd["RezervasyonCesidi"],
                        OdaveCesitID = (int)rd["OdaVeCesit"],
                        UyeID = (int)rd["UyeID"],
                        TotalID = (int)rd["TotalID"]

                    };
                }
                return rezervasyon;
            }
            catch (Exception EX)
            {
                return rezervasyon;
            }
            finally
            {
                cnn.Close();
            }

        }


        public int RezervasyonSil(Musteri musteri)
        {
            cmd = new SqlCommand("delete from rezervasyon where rezervasyonid=@rezId", cnn);
            cmd.Parameters.AddWithValue("@rezId", musteri.RezervasyonID);

            return ExecuteCommand();
        }

        public List<Rezervasyon> UyeIDileRezervasyonKayitlariniGetir(int UyeID)
        {
            cmd = new SqlCommand("select u.UyeID,r.kisisayisi,r.giristarihi,r.cikistarihi,o.OdaID,r.RezervasyonID,m.musteriId,m.ad,m.soyad,m.tckn,rvc.CesitAd,t.TotalFiyat from Uye u join Rezervasyon r on u.UyeID=r.UyeID join OdaVeOdaCesidi ovc on r.OdaVeCesitID=ovc.OdaVeCesitID join Oda o on ovc.odaId=o.odaId join RezervasyonCesidi rvc on r.RezervasyonCesidiID=rvc.RezervasyonCesidiID join MusteriRezervasyon mr on mr.RezervasyonID=r.RezervasyonID join Musteri m on m.MusteriID=mr.MusteriID join Total t on r.TotalID=t.TotalID where u.UyeID=@UyeID", cnn);
            cmd.Parameters.AddWithValue("@UyeID", UyeID);
            

            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    rezervasyonlar.Add(new Rezervasyon
                    {

                        Ad = rd["Ad"].ToString(),
                        Soyad=rd["Soyad"].ToString(),
                        TCKN=rd["TCKN"].ToString(),
                        RezervasyonID=(int)rd["RezervasyonID"],
                         OdaID=(int)rd["OdaID"],
                        GirisTarihi = (DateTime)rd["GirisTarihi"],
                        CikisTarihi = (DateTime)rd["CikisTarihi"],
                        KisiSayisi = (int)rd["KisiSayisi"],
                        TotalFiyat=Convert.ToDecimal(rd["TotalFiyat"])
                        
                         
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
        public int GetSonRezervasyonId()
        {
            cmd = new SqlCommand("select top 1 RezervasyonID from Rezervasyon order by RezervasyonID desc", cnn);
            Rezervasyon rezervasyon = new Rezervasyon();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                
                rezervasyon.RezervasyonID = (int)rd["RezervasyonID"];
               
                rd.Close();
                return rezervasyon.RezervasyonID;
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
