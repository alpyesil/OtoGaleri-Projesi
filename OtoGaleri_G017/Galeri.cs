using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri_G017
{
    class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();

        public int ToplamAracSayisi
        {
            get
            {
                return this.Arabalar.Count;
            }
        }
        public int KiradakiAracSayisi
        {
            get
            {
                int adet = 0;
                foreach (Araba item in this.Arabalar)
                {
                    if (item.Durum == DURUM.Kirada)
                    {
                        adet++;
                    }
                }
                return adet;

            }
        }
        public int GaleridekiAracSayisi
        {
            get
            {

                return this.ToplamAracSayisi - this.KiradakiAracSayisi;

            }

        }//get metodu doldurulacak
        public int ToplamAracKiralanmaSuresi
        {
            get
            {
                int toplam = 0;

                foreach (Araba item in this.Arabalar)
                {
                    toplam += item.ToplamKiralanmaSuresi;
                }
                return toplam;
            }
        }
        public int ToplamAracKiralanmaAdedi
        {
            get
            {
                int toplam = 0;
                foreach (Araba item in Arabalar)
                {
                    if (item.Durum == DURUM.Kirada)
                    {
                        toplam++;
                        int kira = toplam;
                    }

                }
                return toplam;
            }
        }

        public double Ciro { get; }


        public void ArabaEkle1() //Kontrol sonrası araç var ise çalışacak kod satırı
        {
            Console.Write("Plaka: ");
            string plaka = Console.ReadLine().ToUpper();

            Araba kontrol = null;
            foreach (Araba item in Arabalar)
            {
                if (plaka == item.Plaka)
                {
                    kontrol = item;
                    break;
                }
            }

            if (kontrol != null)
            {
                Console.WriteLine("Aynı plakada araç mevcut. Girdiğiniz plakayı kontrol edin.");
                ArabaEkle1();
            }
            else
            {
                Console.Write("Marka: ");
                string marka = Console.ReadLine();
                Console.Write("Kiralama Bedeli: ");
                float v = float.Parse(Console.ReadLine());
                float kiralamaBedeli = v;
                Console.WriteLine(" Araç Tipleri");
                Console.WriteLine("-SUV için 1");
                Console.WriteLine("- Hatchback için 2");
                Console.WriteLine("- Sedan için 3");
                Console.Write("Araç Tipi: ");
                ARAC_TIPI aracTipi = (ARAC_TIPI)int.Parse(Console.ReadLine());

                switch (aracTipi)
                {
                    case ARAC_TIPI.Empty:
                        break;
                    case ARAC_TIPI.SUV:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    case ARAC_TIPI.Sedan:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    case ARAC_TIPI.Hatchback:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    default:
                        break;
                }
                this.Arabalar.Add(new Araba(plaka, marka, kiralamaBedeli, aracTipi));
            }
        }

        public void ArabaEkle()
        {
            Console.WriteLine();
            Console.WriteLine("-Yeni Araç Ekle-");
            Console.Write("Plaka: ");
            string plaka = Console.ReadLine().ToUpper();

            Araba kontrol = null;
            foreach (Araba item in Arabalar)
            {
                if (plaka == item.Plaka)
                {
                    kontrol = item;
                    break;
                }
            }

            if (kontrol != null)
            {
                Console.WriteLine("Aynı plakada araç mevcut. Girdiğiniz plakayı kontrol edin.");
                ArabaEkle1();
            }
            else
            {
                Console.Write("Marka: ");
                string marka = Console.ReadLine();
                Console.Write("Kiralama Bedeli: ");
                float v = float.Parse(Console.ReadLine());
                float kiralamaBedeli = v;
                Console.WriteLine(" Araç Tipleri");
                Console.WriteLine("-SUV için 1");
                Console.WriteLine("- Hatchback için 2");
                Console.WriteLine("- Sedan için 3");
                Console.Write("Araç Tipi: ");
                ARAC_TIPI aracTipi = (ARAC_TIPI)int.Parse(Console.ReadLine());

                switch (aracTipi)
                {
                    case ARAC_TIPI.Empty:
                        break;
                    case ARAC_TIPI.SUV:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    case ARAC_TIPI.Sedan:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    case ARAC_TIPI.Hatchback:
                        Console.WriteLine();
                        Console.WriteLine("Araç başarılı bir şekilde eklendi.");
                        break;
                    default:
                        break;
                }
                this.Arabalar.Add(new Araba(plaka, marka, kiralamaBedeli, aracTipi));
            }

        } //Kontolsüz araç ekleme

        public void DummyDataAraba(string plaka, string marka, float kiralamaBedeli, ARAC_TIPI aracTipi)
        {
            this.Arabalar.Add(new Araba(plaka, marka, kiralamaBedeli, aracTipi));
        }

        public void ArabaSildir()
        {
            Console.WriteLine("- Araba Sil -");
            Console.Write("Silinmek istenen araç plakasını girin: ");
            string plaka = Console.ReadLine().ToUpper();

            Araba sil = null;
            foreach (Araba item in Arabalar)
            {
                if (plaka == item.Plaka)
                {
                    sil = item;
                    break;
                }
            }

            if (sil != null)
            {
                //Console.WriteLine("Plaka: " + sil.Plaka);
                //Console.WriteLine("Marka: " + sil.Marka);
                //Console.WriteLine("Kiralama Bedeli: " + sil.KiralamaBedeli);
                //Console.WriteLine("Araç Tipi: " + sil.AracTipi);
                //Console.WriteLine("Plaka: " + sil.Plaka);

                Arabalar.Remove(sil);
                Console.WriteLine();
                Console.WriteLine("Araç silindi.");
            }
            else
            {
                Console.WriteLine("Bu plakaya ait araç bulunmamaktadır.");
                ArabaSildir();
            }

        }

        public void ArabaKirala()
        {
            Console.WriteLine("-Araç Kirala-");
            Console.Write("Kiralanacak aracın plakası:");
            string plaka = Console.ReadLine();

            Araba a = null;
            foreach (Araba item in this.Arabalar)
            {
                if (item.Plaka == plaka.ToUpper())
                {
                    a = item;
                    break;
                }
            }

            if (a == null)
            {
                Console.WriteLine("Galeriye ait bu plakada bir araç yok.");
                ArabaKirala();

            }
            if (a.Durum == DURUM.Kirada)
            {
                Console.WriteLine("Araç müsait değil. Başka bir araç seçin.");
                ArabaKirala();
            }
            else
            {
                Console.Write("Kiralama süresi: ");
                int sure = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(plaka.ToUpper() + " Plakalı araç " + sure + " saatliğine kiralandı.");
                a.Durum = DURUM.Kirada;
                a.KiralanmaSureleri.Add(sure);
            }

        }


        public bool KiradaArabaVarMi()
        {
            foreach (Araba item in Arabalar)
            {
                if (item.Durum == DURUM.Kirada)
                {
                    return true;
                }

            }
            return false;



        }

        public void ArabaTeslim()
        {
            Console.WriteLine();
            Console.WriteLine("-Araç Teslim-");

            if (KiradaArabaVarMi() == false)
            {
                Console.WriteLine("Tüm araçlar zaten galeride.");

            }
            else
            {
                Console.Write("Teslim edilecek aracın plakası:");
                string plaka = Console.ReadLine().ToUpper();

                Araba kontrol = null;
                foreach (Araba item in Arabalar)
                {
                    if (plaka == item.Plaka)
                    {
                        kontrol = item;
                        break;
                    }
                }

                if (kontrol == null)
                {
                    Console.WriteLine("Galeriye ait bu plakada bir araç yok.");
                    ArabaTeslim();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Araç galeride beklemeye alındı.");
                    kontrol.Durum = DURUM.Galeride;
                }
            }
        }

        public void GaleridekiArabalar()
        {
            Console.WriteLine();
            Console.WriteLine("Plaka         Marka          Kiralma Bedeli          Araç Tipi         Kiralanma Sayısı            Durum");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            foreach (Araba item in Arabalar)
            {
                if (item.Durum == DURUM.Galeride)
                {
                    Console.WriteLine(item.Plaka.PadRight(14, ' ') + item.Marka.PadRight(15, ' ') + item.KiralamaBedeli.ToString().PadRight(24, ' ') + item.AracTipi.ToString().PadRight(18, ' ') + item.KiralanmaSayisi.ToString().PadRight(28, ' ') + item.Durum);
                }
            }
        }

        public void KiradakiArabalar()
        {

            Console.WriteLine("Plaka         Marka          Kiralma Bedeli          Araç Tipi         Kiralanma Sayısı            Durum");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");

            foreach (Araba item in Arabalar)
            {
                if (item.Durum == DURUM.Kirada)
                {
                    Console.WriteLine(item.Plaka.PadRight(14, ' ') + item.Marka.PadRight(15, ' ') + item.KiralamaBedeli.ToString().PadRight(24, ' ') + item.AracTipi.ToString().PadRight(18, ' ') + item.KiralanmaSayisi.ToString().PadRight(28, ' ') + item.Durum);
                }
            }
        }

        public void TumAraclar()
        {
            Console.WriteLine();

            Console.WriteLine("Plaka         Marka          Kiralma Bedeli          Araç Tipi         Kiralanma Sayısı            Durum");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------");


            foreach (Araba item in Arabalar)
            {

                Console.WriteLine(item.Plaka.PadRight(14, ' ') + item.Marka.PadRight(15, ' ') + item.KiralamaBedeli.ToString().PadRight(24, ' ') + item.AracTipi.ToString().PadRight(18, ' ') + item.KiralanmaSayisi.ToString().PadRight(28, ' ') + item.Durum);
            }

        }

        public void BilgileriGoster()
        {
            Console.WriteLine();
            Console.WriteLine("-Galeri Bilgileri-");

            Console.WriteLine("Toplam Araç Sayısı: " + ToplamAracSayisi);
            Console.WriteLine("Kiradaki Araç Sayısı: " + KiradakiAracSayisi);
            Console.WriteLine("Galerideki Araç Sayısı: " + GaleridekiAracSayisi);
            Console.WriteLine("Toplam araç kiralanma süresi: " + ToplamAracKiralanmaSuresi);
            Console.WriteLine("Toplam araç kiralanma adedi: " + ToplamAracKiralanmaAdedi);
            Console.WriteLine("Ciro: " + Ciro);



        }

    }
}
