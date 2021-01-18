using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //örnekleme yapmadan fonkisyonu çağramazsın
            // "fonksiyon class" "add" = "new" "ad"
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(30, 1);
        }
    }
}
