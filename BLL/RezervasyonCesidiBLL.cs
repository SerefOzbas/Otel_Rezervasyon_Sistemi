using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class RezervasyonCesidiBLL
    {
        RezervasyonCesidiDAL RCD;

        public RezervasyonCesidiBLL()
        {
            RCD = new RezervasyonCesidiDAL();
        }

        public List<RezervasyonCesidi> List()
        {
            return RCD.RezervasyonCesitleriniGoster();

        }

        public decimal GetMoneyById(int rezCesidiID)
        {
            return RCD.GetMoneyById(rezCesidiID);
        }

        public bool Add(RezervasyonCesidi rezervasyonCesidi)
        {
            int result = RCD.AddRezervasyonCesit(rezervasyonCesidi);
            return result > 0;
        }
    }
}
