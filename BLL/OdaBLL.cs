using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class OdaBLL
    {
        OdaDAL _odaDAL;
        public OdaBLL()
        {
            _odaDAL = new OdaDAL();
        }

        public bool Add(Oda oda)
        {
            int result = _odaDAL.AddOda(oda);
            return result > 0;
        }
        public bool Update(Oda oda)
        {
            int result = _odaDAL.UpdateOda(oda);
            return result > 0;
        }
        public bool Delete(Oda oda)
        {
            int result = _odaDAL.DeleteOda(oda);
            return result > 0;
        }
        public List<Oda> List()
        {
            return _odaDAL.GetAllOda();
        }

        public bool SilUpdate(Rezervasyon   rezervasyon)
        {
            int result = _odaDAL.SilUpdateOda(rezervasyon);
            return result > 0;
        }


        public Oda GetOda(int odaID)
        {
            return _odaDAL.GetOdaById(odaID);
        }


    }
}
