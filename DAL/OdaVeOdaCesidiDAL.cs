using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DAL
{
    public class OdaVeOdaCesidiDAL
    {
        SqlCommand cmd;
        SqlConnection cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security=true");
        //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
        public int GetOdaVeOdaCesidiID(int OdaCesidiID , int OdaID)
        {
            cmd = new SqlCommand("Select OdaVeCesitID from OdaVeOdaCesidi where OdaCesidiID=@OCID and OdaID=@OID ",cnn);
            cmd.Parameters.AddWithValue("@OCID", OdaCesidiID);
            cmd.Parameters.AddWithValue("@OID", OdaID);

            OdaVeOdaCesidi OVC = new OdaVeOdaCesidi();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                OVC.OdaVeCesitID = (int)rd["OdaVeCesitID"];
                return OVC.OdaVeCesitID;
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

       public decimal GetMoney(int ID)
        {
            //cnn = new SqlConnection(@"server=DESKTOP-UGHD8MH; database=OtelRezervasyon; Integrated Security = true");
            cnn = new SqlConnection("server=.;database=OtelRezervasyon;Integrated Security = true");

            cmd = new SqlCommand("Select Fiyat from OdaVeOdaCesidi where OdaVeCesitID=@ovcid", cnn);
            cmd.Parameters.AddWithValue("@ovcid", ID);

            OdaVeOdaCesidi OVC = new OdaVeOdaCesidi();
            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                OVC.Fiyat = (decimal)rd["Fiyat"];
                return OVC.Fiyat;
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

        public OdaVeOdaCesidi IDyeGoreOdaGetir(int odavecesitId)
        {
            cmd = new SqlCommand("select * from OdaVeOdaCesidi where OdaVeCesitID=@OdaVeCesidiID", cnn);

            cmd.Parameters.AddWithValue("@OdaVeCesidiID", odavecesitId);

            OdaVeOdaCesidi odavecesidi = null;

            try
            {
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    odavecesidi= new OdaVeOdaCesidi()
                    {
                        OdaCesidiID = (int)rd["OdaCesidiID"],
                        OdaID = (int)rd["OdaID"],
                        OdaVeCesitID = (int)rd["OdaVeCesitID"]
                    };
                }
                return odavecesidi;
            }
            catch (Exception hata)
            {
                return odavecesidi;
            }
            finally
            {
                cnn.Close();
            }

        }

    }
}
