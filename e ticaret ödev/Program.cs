using System;

namespace e_ticaret_ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[] {"Kitap","Defter","Oyuncak","Elektronik","Hobi" 
            };
            for (int i = 0; i < urunler.Length ; i++)
            {
                Console.WriteLine(urunler[i]);

            }
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun);
            }
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a]);
                a += 1;

            }


        }
    }
}
