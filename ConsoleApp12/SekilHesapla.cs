using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class SekilHesapla//Sekil hesaplama sınıfı oluşturduk
    {
        public void HesaplaMenusu()//hesapla menüsü Oluşturduk
        {
            //Seçim Kontrol ve Menü Gösterimi başlangıcı
            string secim;
            do
            {
                Console.WriteLine("Lütfen Secim Yapınız");//Seçim Yaptırıyoruz.
                Console.WriteLine("1 - Kare");
                Console.WriteLine("2 - Dikdörtgen");
                Console.WriteLine("3 - Üçgen");
                Console.Write("Seçiminiz: ");
                secim = Console.ReadLine();

                if (secim != "1" && secim != "2" && secim != "3")
                {
                    Console.WriteLine("Tekrar giriniz");
                }
            } while (secim != "1" && secim != "2" && secim != "3");
            //Seçim Kontrol ve Menü Gösterimi bitişi

            //----------------------------------------------------------------------------------------------

            //Genişlkik ve yükselik girdilerini aldıgımız ve kotrol ettiğimiz bloklar başlangıcı
            int yükseklik = 0;
            Console.Write("Genişlik giriniz : \n");
            int genislik;
            while (!int.TryParse(Console.ReadLine(), out genislik))//Kontrol
            {
                Console.WriteLine("Lütfen Geçerli Sayı giriniz :d");
            }

            if (secim != "1")//kontrol
            {
                Console.WriteLine("Yükseklik giriniz : ");

                while (!int.TryParse(Console.ReadLine(), out yükseklik))
                {
                    Console.WriteLine("Lütfen geçerli sayı giriniz");
                }
            }
            //Genişlkik ve yükselik girdilerini aldıgımız ve kotrol ettiğimiz bloklar bitişi

            //-----------------------------------------------------------------------------------------------

            //Alınan Seçime göre işlemler başlangıcı
            switch (secim)
            {
                case "1":
                    GeometrikSekil kare = new Kare//nesne üretiyoruz
                    {
                        Genislik = genislik//kullanıcıdan alınan girdiyi property değişkene atıyoruz
                    };
                    int kareAlan = kare.AlanHesapla();//Hesaplama metodunu çağrıyoruz
                    Console.WriteLine($"Karenin Alanı : {kareAlan}");
                    break;
                case "2":
                    GeometrikSekil dikdortgen = new Dikdortgen
                    {
                        Genislik = genislik,
                        Yukseklik = yükseklik
                    };
                    int dikdortgenAlan = dikdortgen.AlanHesapla();
                    Console.WriteLine($"Dikdörtgen alanı : {dikdortgenAlan}");
                    break;
                case "3":
                    GeometrikSekil ucgen = new Ucgen
                    {
                        Genislik = genislik,
                        Yukseklik = yükseklik
                    };
                    int ucgenAlan = ucgen.AlanHesapla();
                    Console.WriteLine($"Üçgenin Alanı : {ucgenAlan}");
                    break;
                default:
                    Console.WriteLine("Geçerli giriş yapınız");
                    break;
            }

        }
    }
}
