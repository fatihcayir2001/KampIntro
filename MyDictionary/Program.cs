using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var kullanicilar = new Dictionary<int, string>();
            
            //Diğer listelerde olduğu gibi Add() metodu ile ekleme yapabiliriz
            kullanicilar.Add(0, "Halil Fatih ÇAYIR");
            kullanicilar.Add(1, "Enes Doğan ÖZBEY");
            kullanicilar.Add(2, "Hamdi NECLİ");
            kullanicilar.Add(3, "Berk TOPAL");
            //Diğer listlerden biraz daha farklı yazdırma işlemi
            //Keyvaluepair dictionarydeki keymiz,
            //ve dictionarydeki value değer tipmiz ne ise onları aynen burada da yazıyoruz
            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine("ID: "+kullanici.Key+" Değer: "+kullanici.Value);
            }
        }
        

    }
    
}
