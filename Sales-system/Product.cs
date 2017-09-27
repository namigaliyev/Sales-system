using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    abstract class Product
    {
        private string urunAdi;
        private double kutleBuyuklugu;
        private double fiyat;

        private int secim;

        protected string UrunAdi
        {
            get
            {
                return urunAdi;
            }
            set
            {
                urunAdi = value;
            }
        }
        protected double KutleBuyuklugu
        {
            get
            {
                return kutleBuyuklugu;
            }
            set
            {
                kutleBuyuklugu = value;
            }

        }
        public double Fiyat
        {
            get
            {
                return fiyat;

            }
            set
            {
                fiyat = value;
            }
        }

        public double yenibakiye;


        //Urunlerin Bilgilerini Ekrana yazdirma methodu
        //Ezilebilir method cunku BitmisUrunler ve YArimamul Urunlerde Bilgileri Ekrana Farkli cikariliyor 
        //ve ezme islemli yapiliyor
        public virtual void BilgiYazdir()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Ismi...:" + UrunAdi);
            Console.WriteLine("Fiyati:" + Fiyat + "TL");
        }

        //ISelmler Kontrol classinda SatinAlma Methodunda Buraya geliyor
        //Bu method Musteriden referans alarak onun bakiyesine erisiyor ve onun uzerinde islemler yapiyor
        public void SatinAlmaIslemleri(Client m)
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("Siparisiniz Kabul edildi");
            m.Bakiye = m.Bakiye - Fiyat;
            //Musteri Bakyesi Ekrana cikariliyor
            Console.WriteLine("Bakiyeniz...:" + m.Bakiye);
            //ve Satin Alma Tarihi 
            Console.WriteLine(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
        }
    }
}
