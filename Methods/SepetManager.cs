using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Name);
            
            

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);


        }
    }
}
