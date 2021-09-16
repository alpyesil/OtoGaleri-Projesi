using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri_G017
{
    class Araba
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }
        public float KiralamaSuresi { get; set; }
        public ARAC_TIPI AracTipi { get; set; }

        public int KiralanmaSayisi
        {
            get
            {
                return this.KiralanmaSureleri.Count;
            }
        }
        public int ToplamKiralanmaSuresi { get; }


        public List<int> KiralanmaSureleri = new List<int>();
        public DURUM Durum { get; set; }



        public Araba(string plaka, string marka, float kiralamaBedeli, ARAC_TIPI aracTipi)
        {

            this.Plaka = plaka.ToUpper();
            this.Marka = marka.ToUpper();
            this.KiralamaBedeli = kiralamaBedeli;
            this.AracTipi = aracTipi;
            
            this.Durum = DURUM.Galeride;
        }

    }

    public enum DURUM
    {
        Empty,
        Kirada,
        Galeride
    }

    public enum ARAC_TIPI
    {
        Empty,
        SUV,
        Sedan,
        Hatchback
    }


}
