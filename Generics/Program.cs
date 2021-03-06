﻿using System;
using System.Collections.Generic;
//izlenilen video https://www.youtube.com/watch?v=eq7lgV0m2so
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Angara");
            sehirler.Add("Angara");
            sehirler.Add("Angara");
            Console.WriteLine(sehirler.Count);
            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");
            sehirler2.Add("İstanbul");

            Console.WriteLine(sehirler2.Count);

        }


    }

    //T type den gelir T tipinde item ekle için kullanırız
    class MyList<T> //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            //videoda 14.dk
            _tempArray = _array;
            _array = new T[_array.Length+1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
