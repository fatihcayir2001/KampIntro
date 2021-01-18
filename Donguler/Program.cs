using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string Kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string Kurs2 = "Programlamaya Başlamak İçin Temel Kurs";
            string Kurs3 = "Java";

            //bu tip veriler array-dizilerde tutulur
            //dizi alttaki gibi oluşturulur

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlamak İçin Temel Kurs",
                "Java","Python","C#"};
            
            for (int i = 0; i < kurslar.Length ; i+=1)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for döngüsü sonu");

            //foreach tek tek diziyi dönmeye yarar
            //dizileri kolay dolaşmak için kullanırız

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            
            Console.WriteLine("sayfa sonu");
        }
    }
}
