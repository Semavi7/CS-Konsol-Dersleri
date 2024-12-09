using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders36
{
    internal class Ogrenci
    {
        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string Adi
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }
        public string Alan
        {
            get { return alan; }
            set { alan = value; }
        }
    }

}
