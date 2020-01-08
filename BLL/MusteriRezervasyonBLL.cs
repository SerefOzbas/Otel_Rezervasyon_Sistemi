using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;
namespace BLL
{
   public  class MusteriRezervasyonBLL
    {
        MusteriRezervasyonDAL _musteriRezDAl;
        public MusteriRezervasyonBLL()
        {
            _musteriRezDAl = new MusteriRezervasyonDAL();
        }

        public bool Add(int musteriID,int rezervasyonID)
        {
        
            int result = _musteriRezDAl.Add(musteriID,rezervasyonID);
            return result > 0;
        }
        public bool Sil(Entities.Rezervasyon rezervasyon)
        {
        
            int result = _musteriRezDAl.MusteriRezervasyonSil(rezervasyon);
            return result > 0;
        }
        public MusteriRezervasyon GetMusteriRezervasyon(int RezervasyonID)
        {
           
            return _musteriRezDAl.GetMusteriRezervasyonId(RezervasyonID);
        }
        public MusteriRezervasyon GetRezervasyon(int MusteriID)
        {
           
            return _musteriRezDAl.GetRezervasyonId(MusteriID);
        }
        public List<MusteriRezervasyon> GetTumMusteriRezervasyon()
        {
           
            return _musteriRezDAl.GetMusteriRezervasyon();
        }

    }
}
