using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class RezervasyonBLL
    {
        RezervasyonDAL _rezervasyonDAL;

        public RezervasyonBLL()
        {
            _rezervasyonDAL = new RezervasyonDAL();
        }

        public int SonRezervasyonID()
        {
            return _rezervasyonDAL.GetSonRezervasyonId();
        }
        public bool Ekle(Rezervasyon rezervasyon)
        {
            int result = _rezervasyonDAL.RezervasyonEkle(rezervasyon);

            return result > 0;

        }

        public bool Güncelle(Rezervasyon rezervasyon)
        {

            int result = _rezervasyonDAL.RezervasyonGuncelle(rezervasyon);
            return result > 0;

        }

        public bool Sil(Entities.Rezervasyon rezervasyon)
        {
            int result = _rezervasyonDAL.RezervasyonSil(rezervasyon);
            return result > 0;

        }

        public List<Rezervasyon> RezervasyonListesi()
        {
            return _rezervasyonDAL.RezervasyonKayitlariniGetir();
        }

        public Rezervasyon RezervasyonGetir(int rezervasyonId)
        {
            return _rezervasyonDAL.IDyeGoreRezervasyonGetir(rezervasyonId);
        }

        public List<Rezervasyon> UyeIDileListele(int UyeID)
        {
            return _rezervasyonDAL.UyeIDileRezervasyonKayitlariniGetir(UyeID);
        }
        public Rezervasyon MusteriIDileListele(int MusteriID)
        {
            return _rezervasyonDAL.MusteriIDyeGoreRezervasyonGetir(MusteriID);
        }















    }
}
