using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Control
    {
        //diger classlarin methodlarini kullanmak icin veya urun uretimi icin nesneler olusturuyoruz
        Client mu = new Client();
        Suppliers td = new Suppliers();
        Processor ic = new Processor();
        Monitor mn = new Monitor();
        Keyboard kv = new Keyboard();
        Business it = new Business();
        Rawmaterials hd = new Rawmaterials();
        Pcp p = new Pcp();
        Bobin b = new Bobin();


        public int secim;
        public int secim2;
        public int secim3;
        public double bakiyear;

        //AnaSayfa paneli
        public void AnaSayfa()
        {
            Console.WriteLine("------ANASAYFA-----");
            //Buradaki Musteri class'ina ait Bilgi Paneli Methodu derlendikden sonra sag taraftaki Bilgileri Kerana yazdiriyor
            //Ve parametreler alarak Panelin Guncel Kalmasini sagliyor
            mu.BilgiPaneli(hd, ic, mn, kv, p, b);
            //Bu set cursorposition'nun amaci bi ustteki BilgiPaneline sag tarafta kordinat vermistik,
            //Bu ise AnaSayfa Panelinin ayni hizada yazilmasi icindir
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("1.Tedarikci Tedariki");
            Console.WriteLine("2.Isletme Uretimi");
            Console.WriteLine("3.Musteri Siparisleri");
            Console.WriteLine("4.Bakiye artirmak");


        }
        public void Urunler()
        {
            //Urunleri gosteren Panel
            Console.WriteLine("------------------------");
            Console.WriteLine("******Bitmis Urunler****");
            Console.WriteLine("1.Islemci");
            Console.WriteLine("2.Monitor");
            Console.WriteLine("3.Klavye");
            Console.WriteLine("*****YariMamul Urunler**");
            Console.WriteLine("4.Pcp");
            Console.WriteLine("5.Bobin");

        }
        public void TedarikciPaneli()
        {
            //Tedarikci Paneli
            Console.WriteLine("Tedarikci Paneli");
            //Burdada yine yukaridaki gibi sag tarafda bilgileri gostermek icin BilgiPanelini Kullandik
            //Aslinda BilgiPaneli sag tarafta hep sabit kalmasi Anabolumlerin hepsinde eklenmis durumda
            mu.BilgiPaneli(hd, ic, mn, kv, p, b);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("1.TedarikciBilgileri");
            Console.WriteLine("2.Hammadde Bilgileri");
        }
        public void IsletmePaneli()
        {
            //Isletme Paneli
            Console.WriteLine("Isletme Paneli");
            //Yine Ayni islemler
            mu.BilgiPaneli(hd, ic, mn, kv, p, b);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("1.Isletme Bilgileri");
            Console.WriteLine("2.Uretilenler");
        }
        public void MusteriPaneli()
        {
            //Musteri Paneli 
            //Digerleri gibi
            Console.WriteLine("Mustefri Paneli");
            mu.BilgiPaneli(hd, ic, mn, kv, p, b);
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("1.Musteri Bilgileri");
            Console.WriteLine("2.Siparis Etmek");
        }

        //Burada AnaSayfanin Gonlendirilmesi islemleri goruluyor
        //Ve Secimlere gore islemler yapiliyor
        public void Islemler()
        {
            //Hep tekrarlanmasi icin dongu
            while (true)
            {
                AnaSayfa();
                //Ana Sayfada Kullaniciya Seciminiz diye soruluyor
                Console.Write("Seciminiz....:");
                secim3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (secim3 == 1)
                {
                    //Eger secimi 1 ise teadrikci Paneli Cagirilacak
                    TedarikciPaneli();
                    //ve Kullaniciya 2 Secim Sunulacak 1.TedarikciBilgileri,2.HammaddeBilgileri 
                    Console.Write("Seciminiz..:");
                    secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        //Secim 1 ise TedarikciBilgileri Ekrana cikarilacak
                        td.BilgiYazdir();
                        Console.ReadKey();
                    }
                    if (secim == 2)
                    {
                        //Secim 2 ise Hammadde Bilgileri ekrana Cikarilacak
                        //Bu method'da parametreler aliyor sebebi satis tarihlerini belirlemek icin
                        hd.BilgiYaz(ic, mn, kv, p, b);
                        Console.ReadKey();
                    }


                }
                //Eger Kullanici AnaSayfada 2 yi sectiyse IsletmePaneline Gonlendirilecek
                else if (secim3 == 2)
                {
                    IsletmePaneli();
                    //Kullaniciya 2 secim Sunulacak 1.Isletme Bilgileri,2.Isletme Tarafindan Uretilen Urunler
                    Console.Write("Seciminiz...:");
                    secim2 = Convert.ToInt32(Console.ReadLine());
                    if (secim2 == 1)
                    {
                        //Secim 1 ise Isletme Bilgileri Ekrana Yazdirilacak
                        it.BilgiYazdir();
                    }
                    else if (secim2 == 2)
                    {
                        //Secim 2 Ise Simdiye Kadar Uretilen Urunler Ekrana Cikarilacak Ve Hangi Tarihte Uretildi 
                        //Bilgileri Ekrana cikarilacak , Eger hicbir Urun Uretilmediyse Bos burakilacak
                        Console.WriteLine("---------------------");
                        //Bu Methodlar referanslar aliyorlar sebebi Urunun Bilgilerine Erise bilmek icin
                        //Mesela Urunun Sayisine Erismek icin veya Uretilme Tarihine Erismek icin
                        it.UretilenIslemciler(ic);
                        it.UretilenMonitorlar(mn);
                        it.UretilenKlavyeler(kv);
                        it.UretilenPcp(p);
                        it.UretilenBobin(b);
                    }
                    Console.ReadKey();

                }
                //Kullanici AnaSayfada 3.u sectiyse Musteri Paneline Yonlendirilecek
                else if (secim3 == 3)
                {
                    //MusteriIslemleri Methodunu Asagida Ayrica yaptim
                    //Aciklamalarina Asagida Bakabilirsiniz
                    MusteriIslemleri();
                }
                //Kullanici AnaSayfada 4.u sectiyse BakiyeArtirmak Islemlerine yonlendirilecek
                else if (secim3 == 4)
                {
                    //BakiyeArt Methodunuda MusteriIslemleri gibi Asagida ayrica Yaptim
                    //Aciklamalara Asagida Bakabilirsiniz
                    BakiyeArt(mu);
                }
                Console.Clear();
            }
        }

        public void MusteriIslemleri()
        {
            //Musteri Anasayfada 3.u secti ve Musteri Paneline yonlendi

            //Musteri Paneli
            MusteriPaneli();

            //Kullaniciya 2 secim sunulacak 1.MusteriBilgileri,2.SiparisEtmek
            Console.Write("Seciminiz..:");
            secim = Convert.ToInt32(Console.ReadLine());

            //Secim 1 ise
            if (secim == 1)
            {
                //Musteri Bilgileri Ekrana Yazdirilacak
                mu.BilgiYazdir();

            }
            //Secim 2 ise
            else if (secim == 2)
            {
                //Urunler Ekrana cikarilacak
                Urunler();
                //Kullanici Siparis Etmek icin bir urun sececek
                Console.Write("Siparisiniz...:");
                secim2 = Convert.ToInt32(Console.ReadLine());

                //Secim 1 ise Birinci Urun olan Islemcinin islemleri yapilacak
                if (secim2 == 1)
                {
                    //Musteri Bakiyesi kontrol edilecek
                    if (mu.Bakiye > ic.Fiyat)
                    {
                        //Bakiye yetiyorsa once Urun bilgileri Ekrana cikarilacak
                        ic.BilgiYazdir();
                        //Sonra Urunun SatinAlma Islemleri gorulecek
                        //Bu Methodun ayrintilari IUrun den Bakabilirsiniz
                        ic.SatinAlmaIslemleri(mu);
                        //Islemcinin Hammaddesi Uretiliyor ve Hammadde referansi alarak
                        //Hmmadde Miktarina erisiyor
                        ic.IslemciHammadde(hd);

                    }
                    else if (mu.Bakiye < ic.Fiyat)
                    {
                        //Bakiye yetmiyorsa islem yapilmayacak
                        Console.WriteLine("****************");
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                //Secim 2 ise Ikinci Urunun islemleri yapilacak
                //Yukaridaki islemlerler ayni
                else if (secim2 == 2)
                {

                    if (mu.Bakiye > mn.Fiyat)
                    {
                        mn.BilgiYazdir();
                        mn.SatinAlmaIslemleri(mu);
                        mn.MonitorHammadde(hd);

                    }
                    else if (mu.Bakiye < mn.Fiyat)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                //Ayni islemler
                else if (secim2 == 3)
                {
                    if (mu.Bakiye > kv.Fiyat)
                    {
                        kv.BilgiYazdir();
                        kv.SatinAlmaIslemleri(mu);
                        kv.KlavyeHammadde(hd);

                    }
                    else if (mu.Bakiye < kv.Fiyat)
                    {
                        Console.WriteLine("***************");
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                //Ayni islemler
                else if (secim2 == 4)
                {
                    if (mu.Bakiye > p.Fiyat)
                    {
                        p.BilgiYazdir();
                        p.SatinAlmaIslemleri(mu);
                        p.PcpHammadde(hd);

                    }
                    else if (mu.Bakiye < p.Fiyat)
                    {
                        Console.WriteLine("*****************");
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }
                else if (secim2 == 5)
                {
                    if (mu.Bakiye > b.Fiyat)
                    {
                        b.BilgiYazdir();
                        b.SatinAlmaIslemleri(mu);
                        b.BobinHammaddde(hd);

                    }
                    else if (mu.Bakiye < b.Fiyat)
                    {
                        Console.WriteLine("Yetersiz Bakiye");
                    }
                }

            }
            Console.ReadKey();
            Console.Clear();

        }
        public void BakiyeArt(Client mi)
        {
            //Bakiye arttirma islemler
            //Yukarida soyledigim gibi Sagdaki Bilgiler tum Panellerde gozukecek
            mu.BilgiPaneli(hd, ic, mn, kv, p, b);

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("------Bakiye Paneli----");
            //Kullanicinin Bakiye girilmesi istenecek

            Console.Write("Bakiye'ye para koyun..:");
            bakiyear = Convert.ToDouble(Console.ReadLine());
            //Burada Girilen deger direk Musteri Bakiyesine Eklenecek
            mi.Bakiye += bakiyear;

        }
    }
}
