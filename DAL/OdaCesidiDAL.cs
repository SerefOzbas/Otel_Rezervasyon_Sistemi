using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class OdaCesidiDAL
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public OdaCesidiDAL()
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");

        }

        /// <summary>
        /// //Tüm oda çeşitlerini getirir.
        /// </summary>
        /// <returns></returns>
        /// 

        public int OdaCesidiEkle(OdaCesidi odacesidi)
        {
            cmd = new SqlCommand("Insert into OdaCesidi (Cesit) values (@cesit)", cnn);
            cmd.Parameters.AddWithValue("@cesit", odacesidi.Cesit);

            return ExecuteCommand();
        }

        public int OdaCesidiGuncelle(OdaCesidi odacesidi)
        {
            cmd = new SqlCommand("update OdaCesidi set Cesit=@cesit where OdaCesidiID=@ocid", cnn);
            cmd.Parameters.AddWithValue("@cesit", odacesidi.Cesit);
            cmd.Parameters.AddWithValue("@ocid", odacesidi.OdaCesidiID);

            return ExecuteCommand();
        }

        public List<OdaCesidi> OdaCesidiKayitlariniGetir() 
        {
            cmd = new SqlCommand("select * from OdaCesidi", cnn);
            List<OdaCesidi> odaCesitleri = new List<OdaCesidi>();

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                while (rd.Read())
                {
                    odaCesitleri.Add(new OdaCesidi
                    {
                        OdaCesidiID = (int)rd["OdaCesidiID"],
                        Cesit = rd["Cesit"].ToString()
                    });

                }
                rd.Close();
                return odaCesitleri;
            }
            catch (Exception)
            {
                return odaCesitleri;
            }
        }
        /// <summary>
        /// // ID'ye göre oda çeşidini getirir.
        /// </summary>
        /// <param name="odaCesidiId"></param>
        /// <returns></returns>
        public OdaCesidi IDyegoreOdaCesidiGetir(int odaCesidiId) 
        {
            cmd = new SqlCommand("select * from odacesidi where odacesidiid=@odacesidiId", cnn);
            cmd.Parameters.AddWithValue("@odacesidiId", odaCesidiId);

            OdaCesidi odaCesidi = null;

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    odaCesidi = new OdaCesidi()
                    {
                        OdaCesidiID = (int)rd["odacesidiid"],
                        Cesit = rd["cesit"].ToString()
                    };
                }

                return odaCesidi;


            }
            catch (Exception)
            {
                return odaCesidi;
            }
            finally
            {
                cnn.Close();
            }
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

