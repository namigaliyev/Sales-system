using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Pcp:Semiproduct
    {
        private int pcpSayisi;
        private DateTime satinAlmaTarihi;

        //Properties
        public int PcpSayisi
        {
            get
            {
                return pcpSayisi;
            }
            set
            {
                pcpSayisi = value;
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
        public Pcp()
        {
            Fiyat = 50;
            KutleBuyuklugu = 2;
        }
        //Burada Hem Hammadde Uretiliyor Hemde iurun sayisini arttiriyoruz
        //Yani Hammadde Uretildigi zaman Urunde Uretilecek
        //Method Hammaddeden Referans aliyor ve Hammadde Miktarina erisiyor
        public void PcpHammadde(Rawmaterials f)
        {//Pcp Uretilmesi icin 3 Hammadde Gerekiyor
            f.Miktari += 3;
            PcpSayisi++;
            //Hammadde satinalma Tarihi
            SatinAlmaTarihi = DateTime.Now;
        }
    }
}
