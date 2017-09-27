using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_system
{
    class Semiproduct:Product
    {
        public override void BilgiYazdir()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Fiyat...:" + Fiyat + " TL");
        }

    }
}
