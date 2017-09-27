using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Processor:Product
    {
        private int islemciSayisi;
        private DateTime satinAlmaTarihi;

        //Properties
        public int IslemciSayisi
        {
            get
            {
                return islemciSayisi;
            }
            set
            {
                islemciSayisi = value;
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


        //Urun Bilgileri
        public Processor()
        {
            UrunAdi = "Islemci123";
            KutleBuyuklugu = 0.1f;
            Fiyat = 500;
        }
        //Burada Hem Hammadde Uretiliyor Hemde iurun sayisini arttiriyoruz
        //Yani Hammadde Uretildigi zaman Urunde Uretilecek
        //Method Hammaddeden Referans aliyor ve Hammadde Miktarina erisiyor
        public void IslemciHammadde(Rawmaterials h)
        {
            //Her bir Urun icin Belirli Sayida Hammadde Gerekiyor 
            //Ve uretilen Hammaddeler.Toplam Hammadde Miktarina ekleniyor
            //islemci Uretimi Icin 6 Hammadde Gerekiyor
            h.Miktari += 6;

            //Islemci sayisi arttiriliyor
            IslemciSayisi++;
            //Hammadde satinalma Tarihi
            SatinAlmaTarihi = DateTime.Now;
        }

    }
}
