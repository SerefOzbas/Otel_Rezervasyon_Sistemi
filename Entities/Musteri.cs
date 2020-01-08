using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entities
{
    public class Musteri
    {
        public decimal Fiyat { get; set; }
        public int OdaCesidiID { get; set; }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public int RezervasyonID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string CesitAd { get; set; }
        public string Cesit { get; set; }
        public decimal TotalFiyat { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        private string _TcKimlikNo;
        public string TcKimlikNo
        {
            get { return _TcKimlikNo; }
            set
            {
                if (value.Length == 11)
                {
                    _TcKimlikNo = value;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Tc kimlik no 11 hane olmalıdır.");
                }
            }
        }
        private string _TelefonNo;
        public string TelefonNo
        {
            get { return _TelefonNo; }
            set
            {
                if (value.Length == 10)
                {
                    _TelefonNo = value;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Lütfen Başına 0 Koymadan Yazınız");
                }
            }
        }

    }
}
