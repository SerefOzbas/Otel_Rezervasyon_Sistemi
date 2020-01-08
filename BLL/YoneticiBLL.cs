using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class YoneticiBLL
    {
        YoneticiDAL _yoneticiDAL;
        public YoneticiBLL()
        {
            _yoneticiDAL = new YoneticiDAL();
        }

        public List<Yonetici> List()
        {
            return _yoneticiDAL.GetAllYonetici();
        }

        public Yonetici GetUye(int yoneticiID)
        {
            return _yoneticiDAL.GetYoneticiByID(yoneticiID);
        }

        public List<Rezervasyon> RezervasyonCesidineGoreListele(int rezervasyonCesidi)
        {
            return _yoneticiDAL.RezervasyonCesidiIleListele(rezervasyonCesidi);
        }

    }
}
