using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
   public  class OdaVeOdaCesidiBLL
    {

        OdaVeOdaCesidiDAL OVCDAL;


        public int OdaCesitleriniIDyeGoreGetir(int OdaCesidiID,int OdaID)
        {
            OVCDAL = new OdaVeOdaCesidiDAL();
            return OVCDAL.GetOdaVeOdaCesidiID(OdaCesidiID,OdaID);
        }

        public decimal GetMoney(int odavecesitID)
        {
            OVCDAL = new OdaVeOdaCesidiDAL();
            return OVCDAL.GetMoney(odavecesitID);
        }
        public OdaVeOdaCesidi IdileOdaVeOdaCesidiGetir(int OdaVeCesitID)
        {
            OVCDAL = new OdaVeOdaCesidiDAL();
            return OVCDAL.IDyeGoreOdaGetir(OdaVeCesitID);
        }

    }

}
