using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Enes", "Hamdi", "Fatih","Berk" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            //dizileri genişletemiyoruz dizide ancak olanla çalışabiliriz
            //o yüzden koleksiyonlarla çalışıcağız
            //soldaki ampülden using system generici seçip eklemen gerek yoksa kullanamazsın
            //list yazıp üzerine gel ampül çıkar
            List<string> isimler2 = new List<string> {"Fatih", "Enes", "Berk", "Hamdi" };
            // böyle ekleyeniliriz isimler2.Add("Fatih");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Burak");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
