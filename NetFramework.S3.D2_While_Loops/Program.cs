using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S3.D2_While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

           /* #region genel gosterim
            while (true) // şart true oldugu surece dongu çalışır. break veya false durumunda donguden çıkar.
            {

            }
            #endregion*/

            #region 1-10 sayılarını yazdırma

            int dongu = 1;

            while (dongu <=10)
            {
                Console.WriteLine(dongu);
                dongu++;
            }


            #endregion

            #region kullanıcıdan gelen degerin 1 eksilterek 0 a kadar yazdır

            string girilenSayi = string.Empty;
            int girSayi = 0;

            Console.WriteLine("lutfen bir sayı giriniz");
            girilenSayi = Console.ReadLine();
            girSayi = int.Parse(girilenSayi);



            for (int i = girSayi; i >=0; i--)
            {
                Console.Write(i +",");
            }
            Console.WriteLine();

            int alfa = 0;
            while(alfa<=girSayi)
            {
                Console.Write(alfa);
                    alfa++;
            }

            while(girSayi !=-1)
            {
                Console.Write(girSayi);
                girSayi--;

            }

            Console.Clear();

            #endregion

            #region kullanıcıdan gelen degerlerin toplamını yazdırmak; dogal sayılar için

            string girSayi_gelen = string.Empty;
            int girSayi2 = 0;

            Console.WriteLine("lutfen bir sayı giriniz");
            girSayi_gelen = Console.ReadLine();
            girSayi2 = int.Parse(girSayi_gelen);

            int toplam_X = 0;
            for (int i = girSayi2; i>= 0; i--)
            {
                toplam_X += i;
            }
            Console.WriteLine("sonuç {0}:",toplam_X);

            int Sonuc_2 = 0;
            while(girSayi2>=0)
            {
                Sonuc_2=Sonuc_2+girSayi2--;
            }
            Console.WriteLine("sonuç2 {0}", Sonuc_2);

            // alternatif

            /*int kullanıcı_gelen = 0;
            while(true)
            {
                string disaridan_gelen = Console.ReadLine();
                int dıs_gelen = int.Parse(disaridan_gelen);
                if (dıs_gelen < 0)
                    break;
                else
                    kullanıcı_gelen = dıs_gelen + kullanıcı_gelen;
            }

            Console.WriteLine("toplam {0}:", kullanıcı_gelen);*/
            #endregion

            #region odev sistemin oluşturdugu 1-10 arası bir degeri kullanıcının tahmin etmesini isteyecek uygulama

            int sistemSure = 0;
            Random rnd = new Random();
            sistemSure=rnd.Next(1, 10);
            Console.Write(sistemSure);

            int tahmin_Adet = 1;

            while(true)
            {
                Console.Write("{0} . deneme - lutfen sistemin sayısını tahmin edin :", tahmin_Adet);
                string SayiBul = Console.ReadLine();
                int Sayi_tahmin = int.Parse(SayiBul);

                if (Sayi_tahmin==sistemSure)
                {
                    tahmin_Adet++;
                    Console.WriteLine("{0} . denemeniz, dogru", tahmin_Adet);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("{0} . denemeniz, tekrar sayı girin", tahmin_Adet);
                    tahmin_Adet++;
                 }
            





            }




            #endregion

            #region do while

            do  // şart ne olursa olsun döngü 1 kere çalışır
            {
                Console.WriteLine("Hi, do while example");
            } while (1==2);




            #endregion

            #region odev do while içersinde kullanıcı adı ve şifre; doğruluyorsa donguden çık -- yanlışsa tekrar denet

            string isimver = string.Empty;
            string sifrever = string.Empty;
            int defa = 0;

            do
            {
                if (defa > 0)
                    Console.WriteLine("yanlıs yazımlar mevcut");

                Console.Write("lutfen isim giriniz");
                isimver = Console.ReadLine();

                Console.Write("lutfen sifre giriniz");
                sifrever = Console.ReadLine();


                defa++;
            } while (isimver.ToLower() != "Kaan" && sifrever.ToLower() != "1234");
                Console.WriteLine("dogru eslesme");


            #endregion

            #region kullanıcıdan 1-x arası sayı girmesini iste; bu degerler arasında sistem sayı tahmini 
            //yapsın bu aralıkta ve kullanıcının girdiği sayıyı tahmin etsin.

            string giveme = string.Empty;
            int findme = 0;
            Console.WriteLine("Lutfen bir sayı giriniz 1-20 arasında");
            giveme = Console.ReadLine();
            findme = int.Parse(giveme)
            
            
            ; //kullanıcının girdiği deger



            int systemGuess = 0;
            Random rndx = new Random();
            systemGuess = rndx.Next(1, 10);
            //Console.Write(systemGuess);

            int guess_adet = 0;

            do
            {
                guess_adet++;

                Console.WriteLine("{0} hakkınızda uretilen sayıyı tahmin edin", guess_adet);
                findme = int.Parse(Console.ReadLine());
                
                

            } while (findme != systemGuess);
            Console.WriteLine("{0} . denemende Ace:", guess_adet);
            




            #endregion
        }
    }
}
