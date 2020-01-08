using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Uye
    {
        public int UyeID { get; set; }
        
        public string Mail { get; set; }

        private string _Sifre;
        public string Sifre
        {
            get { return _Sifre; }
            set
            {
                // bu kontrol BLL des
                if (value.Length <16 || value.Length>8)
                {
                    _Sifre = value;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Lütfen 8 ile 16 karakter arası şifre oluşturun");
                }
            }
        }


    }
}
