using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class TotalBLL
    {
        TotalDAL _totalDAL;
        public TotalBLL()
        {
            _totalDAL = new TotalDAL();
        }
        public List<Total> List()
        {
            return _totalDAL.TotalCesitleriniGoster();
        }
        public Total SonTotal()
        {
            return _totalDAL.GetSonTotalId();
        }
        public bool Add(Total total)
        {
            int result = _totalDAL.TotalEkle(total);
            return result > 0;
        }
    }
}
