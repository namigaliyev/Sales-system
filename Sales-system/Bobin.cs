using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Bobin:Semiproduct
    {
        private int bobinSayisi;
        private DateTime satinAlmaTarihi;

        //Properties
        public int BobinSayisi
        {
            get
            {
                return bobinSayisi;
            }
            set
            {
                bobinSayisi = value;
            }
        }
        public DateTime SatinAlmaTarihi
        {
            get
            {
                return satinAlmaTarihi;
            }
            set
            {
                satinAlmaTarihi = value;
            }
        }
        public Bobin()
        {
            Fiyat = 60;
        }
        //Burada Hem Hammadde Uretiliyor Hemde iurun sayisini arttiriyoruz
        //Yani Hammadde Uretildigi zaman Urunde Uretilecek
        //Method Hammaddeden Referans aliyor ve Hammadde Miktarina erisiyor
        public void BobinHammaddde(Rawmaterials hs)
        {//Bobin Uretilmesi icin 3 Hammadde Gerekiyor
            hs.Miktari += 3;
            BobinSayisi++;
            //Hammadde satinalma Tarihi
            SatinAlmaTarihi = DateTime.Now;
        }
    }
}
