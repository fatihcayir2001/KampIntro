using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        //tek tek int string yazmak yerine " . " koyarak classın değişkenlerine ulaşırız
        //bu yüzden classları kullanırız
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Update (Product product) 
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

        }


        public int Topla(int sayi1, int sayi2) 
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        //Arada ne fark var? neden return kullanıyoruz?
        //Topla daki ortaya çıkan sonucu başka bir yerde kullanabiliriz ama Topla 2 de kullanamyız
        //çünkü topla 2 ekrana yazdırıyor

    }
}
