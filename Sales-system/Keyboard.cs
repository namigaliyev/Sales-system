using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Keyboard:Product
    {
        private int klavyeSayisi;
        private DateTime satinAlmaTarihi;

        //Properties
        public int KlavyeSayisi
        {
            get
            {
                return klavyeSayisi;
            }
            set
            {
                klavyeSayisi = value;
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
        public Keyboard()
        {
            UrunAdi = "Klavye123";
            KutleBuyuklugu = 2;
            Fiyat = 150;
        }

        //Burada Hem Hammadde Uretiliyor Hemde iurun sayisini arttiriyoruz
        //Yani Hammadde Uretildigi zaman Urunde Uretilecek
        //Method Hammaddeden Referans aliyor ve Hammadde Miktarina erisiyor
        public void KlavyeHammadde(Rawmaterials m)
        {//Klavye Uretilmesi icin 4 Hammadde gerekiyor
            m.Miktari += 4;
            KlavyeSayisi++;
            //Hammadde satinalma Tarihi
            SatinAlmaTarihi = DateTime.Now;
        }
    }
}
