using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Client:Information
    {
        Business ig = new Business();


        public int islemcisayisi;
        public int monitorsayisi;
        public int klavyesayisi;

        public int IslemciSayisi
        {
            get
            {
                return islemcisayisi;
            }
            set
            {
                islemcisayisi = value;
            }
        }
        public int MonitorSayisi
        {
            get
            {
                return monitorsayisi;
            }
            set
            {
                monitorsayisi = value;
            }
        }
        public int KlavyeSayisi
        {
            get
            {
                return klavyesayisi;
            }
            set
            {
                klavyesayisi = value;
            }
        }

        //Musteri Bigileri
        public Client()
        {
            MusteriAdi = "Name";
            Adres = "asdasdddfsdffds";
            Telefon = 123456789;
            Mail = "asdasdasd@sadasdadsa";
            Bakiye = 1000;
        }



        //Musteri Bilgilerini ekrana yazdirma
        public void BilgiYazdir()
        {

            Console.WriteLine("Adi..........:" + MusteriAdi);

            Console.WriteLine("Adres........:" + Adres);

            Console.WriteLine("Telefon......:" + Telefon);

            Console.WriteLine("Mail.........:" + Mail);

            Console.WriteLine("Bakiyeniz....:" + Bakiye);


        }

        //Bu method sag taraftaki Bilgileri ekrana yazdirmak icindir
        //Sag tarafta durmasi icin kordinatlar aliyor
        //Ve Parametreler aliyor,sebebi guncel olmasi icindir. her islem goruldugunde ekrana yeniden yazdiriliyor
        //ve Guncelleniyor
        public void BilgiPaneli(Rawmaterials d, Processor i, Monitor m, Keyboard k, Pcp pc, Bobin b)
        {
            Console.SetCursorPosition(80, 0);
            Console.WriteLine("Adi..........:" + MusteriAdi);
            Console.SetCursorPosition(80, 1);
            Console.WriteLine("Adres........:" + Adres);
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("Telefon......:" + Telefon);
            Console.SetCursorPosition(80, 3);
            Console.WriteLine("Mail.........:" + Mail);
            Console.SetCursorPosition(80, 4);
            Console.WriteLine("Bakiyeniz....:" + Bakiye);
            Console.SetCursorPosition(80, 5);
            Console.WriteLine("------------------------");
            Console.SetCursorPosition(80, 6);
            Console.WriteLine("Toplam Uretilen Hammadde..:" + d.Miktari);
            Console.SetCursorPosition(80, 7);
            Console.WriteLine("Islemci " + i.IslemciSayisi + " Tane Uretildi");
            Console.SetCursorPosition(80, 8);
            Console.WriteLine("Monitor " + m.MonitorSayisi + " Tane Uretildi");
            Console.SetCursorPosition(80, 9);
            Console.WriteLine("Klavye  " + k.KlavyeSayisi + " Tane Uretildi");
            Console.SetCursorPosition(80, 10);
            Console.WriteLine("Pcp " + pc.PcpSayisi + " Tane Uretildi");
            Console.SetCursorPosition(80, 11);
            Console.WriteLine("Bobin " + b.BobinSayisi + " Tane Uretildi");
        }
    }
}
