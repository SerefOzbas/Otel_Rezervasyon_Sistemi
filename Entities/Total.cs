using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Total
    {
        public int TotalID { get; set; }
        public int OdaVeCesitID { get; set; }
        public int RezervasyonCesidiID { get; set; }
        public int IndirimOrani { get; set; }
        public decimal OdaVeCesitIDFiyat { get; set; }
        public decimal RezervasyonCesidiIDFiyat { get; set; }
        public decimal TotalFiyat { get; set; }

    }
}
