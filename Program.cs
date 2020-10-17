using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D1.For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=10; i++)
            {
                Console.WriteLine("for loop");
            }
            #region 1-10 arası deger yazdırma ornek

            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i + ". tekrar");
            }

            #endregion

            Console.Clear();

            #region 1-100 arası çift deger yazdırılması ornek
            for (int i = 1; i <= 100; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + "- çift sayıdır");
                }

            }

            #endregion

            Console.Clear();

            #region odev 1-100 arası çif sayıların toplamının yazdırılması

            int toplam = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    toplam += i;
                }
            }
            Console.WriteLine("1-100 arası çift sayıların toplamı : {0}", toplam);
            #endregion

            #region girilen sayı değerinin faktoriyel hesabını yapmak.

            string deger_giris = string.Empty;
            int deger = 0;

            Console.Write("Lutfen bir sayı degeri giriniz : ");
            deger_giris = Console.ReadLine();
            deger = int.Parse(deger_giris);

            int sonuc = 1;

            for (int i = deger; i >=1; i--)
            {
                sonuc *= i;
            }

            Console.WriteLine(" {0} degerinin faktoriyel sonucu : {1}", deger,sonuc);

            #endregion

            
            #region infinite loop
            int hesap = 0;
            for(; ; )
            {
                hesap++;
                //break
                if (hesap == 2) ;
                break; // donguyu kırıyor- donguden çıkasrtır şart sağlanırsa
                //continue // continue anahtar kelimesinde for dongusunun baslangıcına geri doner, kodun alt tarafını çalıştırmaz.
                Console.WriteLine("sonsuz dongu genel yazım");
            }
            #endregion

            Console.Clear();

            #region iç içe for dongusu
            for (int i = 1; i < 20; i++)
            {
                for (int x = 1; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Clear();
            #endregion

            #region odev çarpım tablosu
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int carpım = i * j;
                    Console.Write("{0}*{1}={2} \t",i,j,carpım);
                }
                Console.WriteLine();
            }


            #endregion
            Console.Clear();

            #region for each

            string[] names = new[] { "kaan", "oguz", "mavice", "yekta" };

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }



            #endregion
        }
    }
}
