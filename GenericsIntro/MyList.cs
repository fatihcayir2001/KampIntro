using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items ;
        //ctor yaparak açabiliriz 11.satırı
        //constructor demek
        //array yani diziyi constructor bloğuyla newledik
        public MyList()
        {
            items = new T[0];
        }
        //T dememizin sebebi T olarak ne verirsek istediğmiz elemanın türüde odur.
        public void Add(T item) 
        {
            T[] tempArray = items;         //newleyince referans uçuyor birine tutturmamız lazım
            items = new T[items.Length+1]; //eleman sayısını 1 artırdık
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //şimdi eklenmek istenen elemanı ekledik

        }
        
    }
}
