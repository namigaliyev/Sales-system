using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Monitor:Product
    {
        private int monitorSayisi;
        private DateTime satinAlmaTarihi;

        //Properties
        public int MonitorSayisi
        {
            get
            {
                return monitorSayisi;
            }
            set
            {
                monitorSayisi = value;
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
        public Monitor()
        {
            UrunAdi = "Monitor123";
            KutleBuyuklugu = 1;
            Fiyat = 400;
        }

        //Burada Hem Hammadde Uretiliyor Hemde iurun sayisini arttiriyoruz
        //Yani Hammadde Uretildigi zaman Urunde Uretilecek
        //Method Hammaddeden Referans aliyor ve Hammadde Miktarina erisiyor
        public void MonitorHammadde(Rawmaterials d)
        {//Monitor Uretmek icin 5 Hammadde gerekiyor
            d.Miktari += 5;
            MonitorSayisi++;
            //Hammadde satinalma Tarihi
            SatinAlmaTarihi = DateTime.Now;
        }
    }
}
