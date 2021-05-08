using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemler
{
    class matematikselIslemler
    {
        public static int Toplama(string a, int b)
        {
            int s1 = Convert.ToInt32(a);
            int s2 = Convert.ToInt32(b);
            int sonuc = s1 + s2;
            return sonuc;
        }
    }
    class Islemler
    {
        public static int Cikarma(string a, string b)
        {
            int s1 = Convert.ToInt32(a);
            int s2 = Convert.ToInt32(b);
            int sonuc = s1 - s2;
            return sonuc;
        }

    }
}