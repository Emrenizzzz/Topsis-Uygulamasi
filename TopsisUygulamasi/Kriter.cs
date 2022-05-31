using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopsisUygulamasi
{
    public class Kriter
    {
        public Kriter(string gAdi,string gTürü)
        {
            adi = gAdi;
            türü = gTürü;
        }

        string adi, türü;
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }
        
        public string Türü
        {
            get {  return türü;}
            set { türü = value;}
        }

        double agirlik;
        public double Agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }

        public override string ToString()
        {
            return this.Adi + "-" + this.Türü;
        }

        public string SecondToString()
        {
            return this.Adi;
        }
    }
}
