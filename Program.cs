using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D1.Types
{
    class Program
    {
        static void Main(string[] args)
        {

            // Data Types
            string name;
            name = "Kaan";

            Console.Write("User Name : ");
            Console.WriteLine(name);

            int i = 4;
            int y = i;

            Console.Write("i nin degeri ");
            Console.WriteLine(i);
            Console.Write("y nin degeri ");
            Console.WriteLine(y);

            y = 10;

            Console.Write("i nin degeri ");
            Console.WriteLine(i);
            Console.Write("y nin degeri ");
            Console.WriteLine(y);

            int sayi1 = 0;
            sayi1 = int.MinValue;
            Console.WriteLine("En dusuk deger :");
            Console.WriteLine(sayi1);

            sayi1 = int.MaxValue;
            Console.WriteLine("En buyuk deger :");
            Console.WriteLine(sayi1);

            double sayi2 = double.MinValue;
            Console.WriteLine(sayi2);

            //alt islem block
            {

                int toplam = 30;
                Console.WriteLine(toplam);
                toplam = 40;
                Console.WriteLine(toplam);
                sayi2 = 100;

                /*alt islem blogundaki islemler ramdan silinir,
                orneğin toplam degiskenini alt bloktan çıkıp yazdırsak;
                yazmaz. Ama eğer alt blokta yaptığımız işlem üst bloktaki
                değişkeni etkiliyorsa; bu değişken yapılan işlemin sonucu ile
                alt blok un dışında da çalışır.*/
            }

            Console.WriteLine(sayi2);

            Console.ReadLine();
        }

    }
}
