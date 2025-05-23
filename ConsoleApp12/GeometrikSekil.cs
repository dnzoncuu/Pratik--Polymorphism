using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp12 
{
    public class GeometrikSekil//Base Sınıfımız
    {
        public int Genislik {  get; set; }//properties
        public int Yukseklik { get; set; }

        public virtual int AlanHesapla()//Alan hesapla metodumuz 
        {
            return Genislik * Yukseklik;
        }
    }

    public class Kare : GeometrikSekil//Kare sınıfı , GemoterikSekil sınıfından miral alıyor.
    {
        public override int AlanHesapla()//Override Edilmiş metot
        {
          
            return  Genislik * Genislik;
        }
    }

    public class Dikdortgen : GeometrikSekil
    {
        public override int AlanHesapla()
        {
            return base.AlanHesapla();//override ettik ancak değiştirmedik base haliyle kullandık
        }
    }

    public class Ucgen: GeometrikSekil
    {
        public override int AlanHesapla()
        {

            return (Genislik * Yukseklik) / 2;
        }
    }
}
