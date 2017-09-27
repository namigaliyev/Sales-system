using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Rawmaterials:Information
    {
        public string adi;
        public double miktari;
        public double barkodN;
        public string tedarikciIsmi;
        public DateTime satinAlmaTarihi;
        public int minSiparisM;


        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value;
            }
        }
        public double Miktari
        {
            get
            {
                return miktari;
            }
            set
            {
                miktari = value;
            }
        }
        public double BarkodN
        {
            get
            {
                return barkodN;
            }
            set
            {
                barkodN = value;
            }
        }
        public string TedarikciIsmi
        {
            get
            {
                return tedarikciIsmi;
            }
            set
            {
                tedarikciIsmi = value;
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
        public int MinSaparisM
        {
            get
            {
                return minSiparisM;
            }
            set
            {
                minSiparisM = value;
            }
        }

        //Hammadde Bilgileri
        public Rawmaterials()
        {
            Adi = "Kondansator";
            BarkodN = 159753456852;
            TedarikciIsmi = "fdafdagfd";
            MinSaparisM = 2;
            Miktari = 0;
        }

        //Hammadde Bilgilerini Ekrana Yazdirmada Method Referanslar aliyor
        //Urunleri en son siparis tarihleri Gosteriliyor
        public void BilgiYaz(Processor ib, Monitor mn, Keyboard kl, Pcp pc, Bobin bn)
        {

            Console.WriteLine("Adi....:" + Adi);
            Console.WriteLine("Miktari:" + Miktari);
            Console.WriteLine("Barkod Numarasi:" + BarkodN);
            Console.WriteLine("Tedarikci Ismi.:" + TedarikciIsmi);
            Console.WriteLine("Satin Alma Tarihi:?????");
            Console.WriteLine("Minimum Siparis Miktari:" + MinSaparisM);
            Console.WriteLine("Islemci icin satin alma Tarihi..:" + ib.SatinAlmaTarihi);
            Console.WriteLine("Monitor icin satin alma Tarihi..:" + mn.SatinAlmaTarihi);
            Console.WriteLine("Klavye icin satin alma Tarihi..:" + kl.SatinAlmaTarihi);
            Console.WriteLine("Pcp icin satin alma Tarihi..:" + pc.SatinAlmaTarihi);
            Console.WriteLine("Bobin icin satin alma Tarihi..:" + bn.SatinAlmaTarihi);



        }
    }
}
