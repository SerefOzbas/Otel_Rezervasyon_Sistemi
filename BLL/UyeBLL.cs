using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using DAL;

namespace BLL
{
    public class UyeBLL
    {
        UyeDAL _uyeDAL;
        public UyeBLL()
        {
            _uyeDAL = new UyeDAL();
        }

        public List<Uye> List()
        {
            return _uyeDAL.GetAllUye();
        }

        public Uye GetUye(int uyeId)
        {
            return _uyeDAL.GetUyeByID(uyeId);
        }

        public bool Add(Uye uye)
        {
            int result = 0;
            if (ValidateSifre(uye.Sifre)&& ValidateMail(uye.Mail))
            {
                result = _uyeDAL.AddUye(uye);              
            }
            return result > 0;
        }

        public bool Update(Uye uye, bool isCheck)
        {
            ValidateSifre(uye.Sifre);
            if (isCheck)
            {
                ValidateSifre(uye.Sifre);
            }
            int result = _uyeDAL.UpdateUye(uye);
            return result > 0;
        }

        public bool Delete(Uye uye)
        {
            int result = _uyeDAL.DeleteUye(uye);
            return result > 0;
        }


        bool ValidateSifre(string sifre)
        {
            char[] olumsuz = new char[] { '\\', '/', ':', '*', '\"', '<', '>', '|' };
            foreach (char item in olumsuz)
            {
                if (sifre.Contains(item))
                {
                    MessageBox.Show("Geçersiz karakter girdiniz");
                    return false;
                }
                else if (string.IsNullOrEmpty(sifre))
                {
                    System.Windows.Forms.MessageBox.Show("Sifre Boş");
                    return false;
                }
                else if (sifre.Length < 8 || sifre.Length > 16)
                {
                    System.Windows.Forms.MessageBox.Show("Sifre 8 Karakterden az veya 16 karakterden fazla olamaz.!");
                    return false;
                }

            }
            return true;
        }

        bool ValidateMail(string mail)
        {
            string[] kontrol = new string[] { "@", ".com" };
            foreach (string item in kontrol)
            {
                if (string.IsNullOrEmpty(mail))
                {
                    System.Windows.Forms.MessageBox.Show("Kullanıcı adı boş");
                    return false;
                }
                else if (!mail.Contains(item))
                {
                    MessageBox.Show("Hatalı kullanıcı girişimi");
                    return false;
                }
            }
            return true;
        }

        //public List<Uye> GetRezervasyonBilgileri(int uyeId)
        //{
        //    return _uyeDAL.GetRezervasyonBilgileriByID(uyeId);
        //}


    }
}
