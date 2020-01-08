using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    
    public class OdaCesidiBLL
    {
        OdaCesidiDAL _odaCesidiDAL;
   
        public List<OdaCesidi> OdaCesitleriniGetir()
        {
            _odaCesidiDAL = new OdaCesidiDAL();
            return _odaCesidiDAL.OdaCesidiKayitlariniGetir();
        }

        public OdaCesidi OdaCesitleriniIDyeGoreGetir(int odaCesidiId)
        {
            _odaCesidiDAL = new OdaCesidiDAL();
            return _odaCesidiDAL.IDyegoreOdaCesidiGetir(odaCesidiId);
        }

        public bool Add (OdaCesidi odacesidi)
        {
            _odaCesidiDAL = new OdaCesidiDAL();

            return _odaCesidiDAL.OdaCesidiEkle(odacesidi) > 0;
        }

        public bool Update(OdaCesidi odacesidi)
        {
            _odaCesidiDAL = new OdaCesidiDAL();

            return _odaCesidiDAL.OdaCesidiGuncelle(odacesidi) > 0;
        }

    }
}
