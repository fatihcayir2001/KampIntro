using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 3, UnitsInStock = 31, 
                ProductName = "Sandalye",UnitPrice = 50 };

            //PascalCase  //camelCase
            ProductManager productManager = new ProductManager();
            
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //int,double,bool ... değer tip
            //diziler,class,abstract class... referans tip

            int ToplamaSonucu = productManager.Topla(3, 6); //return olarak dönen değeri sonuca atadkk


        }
    }
}
