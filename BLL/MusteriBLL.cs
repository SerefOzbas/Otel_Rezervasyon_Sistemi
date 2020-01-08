using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;


namespace BLL
{
    public class MusteriBLL
    {
        MusteriDAL _musteriDAL;
        public MusteriBLL()
        {
            _musteriDAL = new MusteriDAL();
        }
        public int SonMusteriID()
        {
            return _musteriDAL.GetSonMusteriId();
        }
        public bool Add(Musteri Musteri)
        {
            int result = _musteriDAL.AddMusteri(Musteri);
            return result > 0;
        }
        public bool Update(Musteri Musteri)
        {
            int result = _musteriDAL.UpdateMusteri(Musteri);
            return result > 0;
        }
        public bool Delete(Musteri Musteri)
        {
            int result = _musteriDAL.DeleteMusteri(Musteri);
            return result > 0;
        }
        public List<Musteri> List()
        {
            return _musteriDAL.GetAllMusteri();
        }
        public Musteri GetMusteri(int musteriID)
        {
            return _musteriDAL.GetMusterisById(musteriID);
        }
    }


}

