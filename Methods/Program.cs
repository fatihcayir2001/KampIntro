using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır karpuzu";

            Product[] products = new Product[] {product1,product2 };

            //type-safe -- tip güvenli 
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------");



            }
            Console.WriteLine("------------Methods--------------");

            //instance - örneklemedir
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma","Yeşil Elma",12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 31);





        }
    }
}

//metotlar tekrar tekrar kullanabilirliği sağlar
//do not repeat yourself kuralına uymamıza sağlar
