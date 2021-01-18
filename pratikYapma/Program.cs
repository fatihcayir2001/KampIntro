using System;

namespace pratikYapma
{
    class Program
    {
        static void Main(string[] args)
        {
            Urunler urun1 = new Urunler();
            urun1.Ad = "Tablet";
            urun1.Fiyat = 50;
            urun1.Stok = 50;

            Urunler urun2 = new Urunler();
            urun2.Ad = "Laptop";
            urun2.Fiyat = 500;
            urun2.Stok = 10;

            Urunler[] urunler = new Urunler[] { urun1, urun2 };
            foreach (var urun in urunler)
            {
                if (urun.Fiyat < 100)
                {
                    Console.WriteLine("Ürün çok ucuz " +" "+ urun.Ad);
                }
                else if (urun.Fiyat > 400)
                {
                    Console.WriteLine("Urun çok pahalı" + " " + urun.Ad);
                }
            }
            string[] Liste = new string[] {"Baybars", "Fatih","Merve","Mehmet","Kuzen" };
            
            void Ekle(string isim)
            {
                int uzunluk = Liste.Length ;
                Liste[uzunluk] = isim;
            }

            Ekle("Kuzen");
            Console.WriteLine(Liste);


        }
    }
}
