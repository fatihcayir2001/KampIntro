using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = bir şey tanımlamadan veri tipini önüne yazcan
            //tek tırnak metinselde kullanma
            //Do not repeat yourself - Kendini tekrar etme!

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 40000;              //integer
            double faizOrani = 1.45;                //double ve float
            bool sistemeGirisYapmisMi = true;       //boolean 
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Çizgi");
            }

            //iki defa taba basarsan kolayca oluşturur
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            



        }
    }
}
