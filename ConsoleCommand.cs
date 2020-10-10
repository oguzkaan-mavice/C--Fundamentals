using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D5.ConsoleCommand
{
    class Program
    {
        static void Main(string[] args)
        {

            string kullanicidangelenDeger = string.Empty;

            // kullanıcıya mesaj gostermek


            Console.Write("Mesaj 2");
            Console.WriteLine("Mesaj 1");

            //ekranda bulunan datayı silmek

            Console.Clear();

            //kullanıcadan deger almak

            Console.Write("adınızı giriniz");
            kullanicidangelenDeger=Console.ReadLine();

            // değişkenleri kullanarak kullanıcıya mesaj göstermenin yontemleri

            string mesaj = "Girmis oldugunuz isim degeri" + kullanicidangelenDeger;
            Console.WriteLine(mesaj);

            Console.Clear();

            mesaj = "";
            mesaj=string.Format("Girmis oldugunuz isim degeri {0}", kullanicidangelenDeger);


            Console.Clear();


            mesaj = Console.WriteLine("Girmis oldugunuz isim degeri : {0}", kullanicidangelenDeger);

            Console.Clear();

            Console.Write("lutfen 1 ile 10 arasında deger giriniz");
            string gelenDeger = Console.ReadLine();

            int sayi1 = int.Parse(gelenDeger); // gelen string degeri int'e cevirdim Parse ile

            int sayi2 = Convert.ToInt32(gelenDeger);

            int toplam = sayi1 + 15;
            int toplam2 = sayi2 + 15;
            Console.WriteLine("Toplam deger : {0}", toplam);
            Console.WriteLine("Toplam deger : {0}", toplam2);

            Console.ReadLine();

        




        }
    }
}
