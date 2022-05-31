using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopsisUygulamasi
{
    internal class Alternatif
    {
        public Alternatif(string gAd)
        {
            ad = gAd;
        }

        

        string ad;
        

        
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public override string ToString()
        {
            return this.Ad;
        }
        
    }
}
