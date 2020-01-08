using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rezervasyon
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKN { get; set; }
        public int RezervasyonID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int KisiSayisi { get; set; }
        public int RezervasyonCesidiID { get; set; }
        public int OdaveCesitID { get; set; }
        public int OdaID { get; set; }
        public string Cesit { get; set; }
        public int UyeID { get; set; }
        public int TotalID { get; set; }
        public decimal TotalFiyat { get; set; }

    }
}
