using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RezervasyonCesidi
    {
        public int RezervasyonCesidiID { get; set; }
        public string CesitAd { get; set; }

        public Decimal Fiyat { get; set; }

        public string Aciklama { get; set; }

    }
}
