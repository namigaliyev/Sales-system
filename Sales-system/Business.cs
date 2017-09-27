using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Business:Information
    {
        //Isletme Bilgileri
        public void BilgiGir()
        {
            IsletmeIsmi = "asadafasf";
            Adres = "asfasfasf";
            Fax = "sada4646as";
            Telefon = 123456789;
            Mail = "asfsafsfdg@safasf";
            WebsiteLink = "dasfasfgsgg";

        }

        //Bigileri ekrana yazdirma
        public void BilgiYazdir()
        {
            BilgiGir();
            Console.WriteLine("Isletme Ismi:" + IsletmeIsmi);
            Console.WriteLine("Adres.......:" + Adres);
            Console.WriteLine("Fax.........:" + Fax);
            Console.WriteLine("Telefon.....:" + Telefon);
            Console.WriteLine("Mail........:" + Mail);
            Console.WriteLine("WebSiteLink.:" + WebsiteLink);
        }

        //Bu methodlar Isletme Panelindeki Uretilenler Bolumunu olusturuyor
        //Mesela UretilenIslemciler Methodu Islemciden referans Aliyor sonra IslemciSayisini kontrol ediyor
        //Eger IslemciSayisi 0 dan buyukse, yani islemci Uretilmisse , Uretilen Islemcisayisi ekrana yazdiriyor
        //Ve son Siparis Tahinide Ekrana yazdiriyor
        //Asagidaki Methodlarin Calisma Prensipleri boyledir
        public void UretilenIslemciler(Processor i)
        {

            if (i.IslemciSayisi > 0)
            {

                Console.WriteLine("Islemci  " + i.IslemciSayisi + "  Tane Uretildi");
                Console.WriteLine("En son Uretilme Tarihi..:" + i.SatinAlmaTarihi);

            }

        }
        public void UretilenMonitorlar(Monitor m)
        {
            if (m.MonitorSayisi > 0)
            {
                Console.WriteLine("Monitor " + m.MonitorSayisi + " Tane Uretildi");
                Console.WriteLine("En son Uretilme Tarihi..:" + m.SatinAlmaTarihi);

            }
        }

        public void UretilenKlavyeler(Keyboard k)
        {

            if (k.KlavyeSayisi > 0)
            {
                Console.WriteLine("Klavye  " + k.KlavyeSayisi + " Tane Uretildi");
                Console.WriteLine("En son Uretilme Tarihi..:" + k.SatinAlmaTarihi);
            }
        }
        public void UretilenPcp(Pcp c)
        {
            if (c.PcpSayisi > 0)
            {
                Console.WriteLine("Pcp " + c.PcpSayisi + " Tane Uretildi");
                Console.WriteLine("En son Uretilme Tarihi..:" + c.SatinAlmaTarihi);

            }
        }
        public void UretilenBobin(Bobin b)
        {
            if (b.BobinSayisi > 0)
            {
                Console.WriteLine("Bobin " + b.BobinSayisi + " Tane Uretildi");
                Console.WriteLine("En son Uretilme Tarihi..:" + b.SatinAlmaTarihi);

            }
        }
    }
}
