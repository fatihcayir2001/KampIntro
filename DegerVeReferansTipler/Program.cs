using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 30;
            //sayi1 = sayi2;
            //sayi2 = 65;
            ////sayi1 ?? (30karşim)
            ////sayi 1 e değer atadık ve bitti 
            ////fakat aşağıda reference tipte birbirine bağlılar yani ayıramayız.
            //int[] sayilar1 = new int[] { 10, 20, 30 };
            //int[] sayilar2 = new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0]=999;
            //sayilar1[0] 999 basacak çünkü referans tip sayılar 1 ve sayılar 2 bağlantılı, referans tip

            //int deciml float double bool bunlar değer tip
            //array, class, interface bunlar referans tiptir


            Person person1 = new Person();
            Person person2 = new Person();
            person1.Firstname = "Engin";
            person2 = person1;
            person1.Firstname = "Derin";
            Console.WriteLine(person2.Firstname);
            //referans tipe başka bir örnek
            //person2=person1 diyince person1 in adresini person2 ye atadık
            //bu yüzden person1 in adı değiştirince person2nin de adı değişti

            Customer customer = new Customer();
            customer.Firstname = "Salih";
            Employee employee = new Employee();
            customer.CreditCardNumber = 123456789;
            employee.Firstname = "Enes";
            //customer = employee; diyemeyiz çünkü bunlar farklı tip
            //int ve stringi biribirine atayamayız gibi

            Person person3 = customer; // buna kızmadı çünkü customer aynı zamanda person
            Console.WriteLine(person3.Firstname);

            //Customer customer1 = person1; person customer olmadığından bunu yapamayız 
            Console.WriteLine(((Customer)person3).CreditCardNumber); // bu baxing demek person3ün creditcardnumberi görebildik
            Person person4 = employee;
            employee.EmployeeNumber = 3162;
            //Console.WriteLine(((Employee)person4).EmployeeNumber);

            //hocam ne gerek var dersen de cevap satır 78de

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); //gördüğün gibi employee gönderebiliyoruz
                                         
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }

        
    }

    class Customer:Person // Bu aynı customer aynı zamanda bir persondır demek ve Person'ın bilgilerini de ekle (firstname lastname vsvs)
    {
        public int CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)//buraya customer dersek sadece customer
                                      //employee dersek sadece employee çalıştırabiliriz
                                      //ama person dersek diğerleri personada eşit olduğundan hepsiyle çalışabilirz
        {
            Console.WriteLine(person.Firstname);
        }
    }
}
