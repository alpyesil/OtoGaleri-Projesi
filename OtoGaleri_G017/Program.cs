using System;

namespace OtoGaleri_G017
{
    class Program
    {

        static Galeri OtoGaleri = new Galeri();

        //Bu class'ın Araba Class'ından haberi olmasın.
        //Yapmak istediğimiz her bir veri değişikliği için Galeri class'ına metot açacağız, o metodu kullanacağız.

        static void Main(string[] args)
        {
            Uygulama();
        }


        static void Uygulama()
        {
            SahteVeriGir();
            Menu();

            while (true)
            {
                Console.WriteLine();
                string secim = SecimAL();

                switch (secim)
                {
                    case "1":
                    case "K":
                        OtoGaleri.ArabaKirala();
                        break;
                    case "2":
                    case "T":
                        OtoGaleri.ArabaTeslim();
                        break;
                    case "3":
                    case "R":
                        OtoGaleri.KiradakiArabalar();
                        break;
                    case "4":
                    case "M":
                        OtoGaleri.GaleridekiArabalar();
                        break;
                    case "5":
                    case "A":
                        OtoGaleri.TumAraclar();
                        break;
                    case "6":
                    case "Y":
                        OtoGaleri.ArabaEkle();
                        break;
                    case "7":
                    case "S":
                        OtoGaleri.ArabaSildir();
                        break;
                    case "8":
                    case "G":
                        OtoGaleri.BilgileriGoster();
                        break;
                    default:
                        break;

                }
                Console.WriteLine();
            }

            //her bir menü elemanı için ayrı bir metot yapacağız
            //switch case ile o metotları çağıracağız

        }

        static void Menu()
        {
            Console.WriteLine("Galeri Otomasyon");
            Console.WriteLine("1 - Araba Kirala(K)");
            Console.WriteLine("2 - Araba Teslim Al(T)");
            Console.WriteLine("3 - Kiradaki arabaları listele(R)");
            Console.WriteLine("4 - Galerideki arabaları listele(M)");
            Console.WriteLine("5 - Tüm arabaları listele(A)");
            Console.WriteLine("6 - Yeni araba Ekle(Y)");
            Console.WriteLine("7 - Araba sil(S)");
            Console.WriteLine("8 - Bilgileri göster(G)");
        }

        static string SecimAL()
        {
            string karakterler = "12345678KTRMAYSG";
            string giris;
            while (true)
            {
                Console.Write("Seçiminiz: ");
                giris = Console.ReadLine().ToUpper();

                if (karakterler.IndexOf(giris) > 0)
                {
                    return giris;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı tekrar deneyin.");
                }

            }

        }


        //sahte veri 
        static void SahteVeriGir()
        {
            

            OtoGaleri.DummyDataAraba("12ARB1234", "Ford", 70, ARAC_TIPI.Sedan);
            OtoGaleri.DummyDataAraba("67ARB3457", "Opel", 91, ARAC_TIPI.SUV);

        }










    }
}
