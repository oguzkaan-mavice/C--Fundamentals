using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // +
            // -
            // /
            // *
            // %
            // --
            // ++
            // +=
            // -=
            // /=
            // *=


            // toplama

            int toplamOperatorSayi1 = 10;
            int toplamOperatorSayi2 = 15;
            int toplamOperatorToplam = toplamOperatorSayi1 + toplamOperatorSayi2;
            Console.WriteLine("toplam : " + toplamOperatorToplam);

            /* ekrana girilen iki sayıyı toplama */

            Console.Write("lutfen 1 ile 100 arasında deger giriniz");
            string gelenDeger = Console.ReadLine();

            int sayi1 = int.Parse(gelenDeger);

            Console.Write("lutfen 1 ile 100 arasında deger giriniz");
            string gelenDeger2 = Console.ReadLine();

            int sayi2 = int.Parse(gelenDeger2);

            int sayi3 = sayi1 + sayi2;

            Console.WriteLine("toplam :" + sayi3);

            /* another way */

            string kullanicideger = string.Empty;
            string kullanicideger2 = string.Empty;

            int odev1 = 0;
            int odev2 = 0; // default atamalar

            Console.WriteLine("ilk sayinizi giriniz");
            kullanicideger = Console.ReadLine();

            Console.WriteLine("ikinci sayinizi giriniz");
            kullanicideger2 = Console.ReadLine();

            odev1 = int.Parse(kullanicideger);
            odev2 = int.Parse(kullanicideger2);

            int odevSonuc = odev1 + odev2;
            Console.WriteLine(odevSonuc);

            #region Cıkarma

            int cikarma1 = 30;
            int cıkarma2 = 80;
            int cıkarmasonuc = cikarma1 - cıkarma2;
            Console.WriteLine("cıkarma sonuc:" + cıkarmasonuc);

            // odev -- kullanıcıdan 2 farklı deger al ve çıkarma işlemi yap //

            string cıkartKullanıcı1 = string.Empty;
            string cıkartKullanıcı2 = string.Empty;

            int cıkartOdev1 = 0;
            int cıkartOdev2 = 0;

            Console.WriteLine("ilk sayınızı giriniz : ");
            cıkartKullanıcı1 = Console.ReadLine();

            Console.WriteLine("ikinci sayınızı giriniz :");
            cıkartKullanıcı2 = Console.ReadLine();

            cıkartOdev1 = int.Parse(cıkartKullanıcı1);
            cıkartOdev2 = int.Parse(cıkartKullanıcı2);

            int cıkartSonuc = cıkartOdev1 - cıkartOdev2;
            Console.WriteLine("cıkart sonuc :" + cıkartSonuc);


            #endregion

            #region Bolme


            int bolme = 23;
            int bolme2 = 76;
            int bolmeSonuc = bolme / bolme2;

            Console.WriteLine("bolme Sonuc : " + bolmeSonuc);
            #endregion

            #region carpma

            int carpma = 98;
            int carpma2 = 0;
            int carpmaSonuc = carpma * carpma2;

            Console.WriteLine("carpma sonuc : " + carpmaSonuc);

            #endregion


            #region mod alma

            int mod1 = 34;
            int mod2 = 12;

            int ModSonuc = mod1 % mod2;

            Console.WriteLine("mod sonuc : " + ModSonuc);
            #endregion

            #region -- ++

            int sayiX = 43;
            sayiX++;
            sayiX--;
            sayiX += 6;

            #endregion

            // Karşılaştırma Operatorleri

            /*
             * * <
             * * <=
             * * >
             * * >=
             * * ==
             * * =!
             * * is
             * * as
             * * && : ve
             * * || : veya
             */



        }
    }
}
