using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Suppliers:Rawmaterials
    {
        //Tedarikci Bilgileri
        public void BilgiGir()
        {

            TedarikciIsmi = "asfasfasfsa";
            Adres = "sadasfasfasf";
            Fax = "+464978543";
            Telefon = 487982324;
            Mail = "safasfafs@asdada";
            WebsiteLink = "asfasfaf";


        }

        //Ekrana Yazdirma
        public void BilgiYazdir()
        {
            BilgiGir();
            Console.WriteLine("ISMI.........:" + TedarikciIsmi);
            Console.WriteLine("ADRES........:" + Adres);
            Console.WriteLine("FAX..........:" + Fax);
            Console.WriteLine("TELEFON......:" + Telefon);
            Console.WriteLine("MAIL.........:" + Mail);
            Console.WriteLine("WEBSITELINK..:" + WebsiteLink);
        }
    }
}
