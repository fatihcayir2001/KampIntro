using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //musteri1.SirketAdi Müşterinin şirket adı mı var? işte soyutlama hatası var
            //kişisel müşterinin şirket adı olmaz
            //Sırf birbirine benziyor diye iki müşteriyi birbirinin yerine kullanmayız
            //SOLID

            IndividiualCustomer customer1 = new IndividiualCustomer();
            customer1.CustomerNo = "12345";
            customer1.Name = "Halil Fatih";
            customer1.Surname = "Çayır";
            customer1.TcNo = "123456789";
            customer1.Id = 1;

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54621";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";


            Customer customer3 = new IndividiualCustomer();
            Customer customer4 = new CorporateCustomer();
            //Müşteri classı hem Indıvıdual hem Corporate customerin referansı tutabiliyor
            //Biz bu yüzden müşteri managere Customer diye parametre gönderdik

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            //Olay tamamen base sınıfın diğer sınıfları da tutabilmesinde


        }

    }
}
