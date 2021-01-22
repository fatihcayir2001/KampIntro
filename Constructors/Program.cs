using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //contructor aslında newlediğimiz zaman çalışan bloktur
            //constructor 1 defa çalışır ve daha çalışmaz
            //newleme yapınca Customer bloğu çalışır

            //şimdi iki adet kullanım göstereceğiz
            //2.yi kullanabiliriz şuuan çünkü parametre atadık
            //eğer iki şekilde de kullanmak istiyorsak bir constructor daha açarız (overloading)
            Customer customer1 = new Customer {ID=1, FirstName="Fatih", LastName="Çayır",City="Eskişehir" };
            Customer customer2 = new Customer(2,"Şakir","Çayır","İstanbul");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //constructor bırakmak için ctor yazabiliriz
        //biz bu bloğu yazmasak bile default olarak bu çalışır
        public Customer()
        {

        }
        public Customer(int Id, string firstName,string lastName,string city)
        {
            Console.WriteLine("Yapıcı çalıştı");
            ID = Id;
            FirstName = firstName; //gelen firstNameyi FirstNameye atadık
            LastName = lastName;
            City = city;

        
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
