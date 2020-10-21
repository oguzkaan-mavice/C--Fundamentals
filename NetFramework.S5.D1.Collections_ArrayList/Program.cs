using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace NetFramework.S5.D1.Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            int Capacity = 0;
            int Count = 0;

            // Standart Collections
            /*
             * ArrayList
             * 
             * 
             * 
             */

            #region ArrayList

            ArrayList A1 = new ArrayList();

            A1.Add("Kaan"); // objecten deger aldıgı için farklı datay type'ları ekleyebiliriz.
            A1.Add(98);
            Capacity = A1.Capacity; // arraylist'eki kapasiteyi. İçerisine aktarılan eleman sayısını arttıkça otomatik 4'er artar.
            Count = A1.Count; // arraylisteki deger sayısını gösterir. 

            ArrayList A2 = new ArrayList();
            A2.Add("Lale");
            A2.Add("Papatya");
            A2.Add("Menekse");


            A1.AddRange(A2); // A2 array Listi A1'in içine ekliyoruz.

            Capacity = A1.Capacity;
            Count = A1.Count;


            object O1 = A1[3]; // arraylisteki herhangi bir degere ulasmak.
            string S1 = A1[3].ToString();
            int I1 = (int)A1[1];

            A1[3] = "Makina";// A1 arraylisteki 3. degeri degistiriyorum.

            int IndexValue = A1.IndexOf("Papatya"); // degerin index karşılığını verir.
            bool Kontrol1 = A1.Contains("Mahmut"); // ilgili deger koleksiyonda var mı yok mu diye bakar. True-False çalışır.

            object[] D1 = A1.ToArray(); //ArrayListeki tüm degerleri biz diziye aktarır.


            A1.Remove(98);
            A1.Sort(); // alfabetik sıralama. | liste içinde int oldugu için hata alacak. Onun için yukarda siliyorum.
            A1.Reverse(); // tersten sıralama indexe gore 


            A1.Remove("Menekse"); // A1 arraylisteki "menekse" degerini siliyorum.(with index)
            A1.RemoveRange(1, 1); // Index uzerinden range ile silmek; 1. elemandan basla 1 eleman sil.
            A1.RemoveAt(1); // Direx index'e gore silmek.


            A1.Clear(); // ArrayListedeki tüm degerleri siler ama kapasite aynı alır.
            A1.TrimToSize(); // ArrayListeki capacity'i ilgili koleksiyonun ilk kapasitesine geri dondurur.

            #endregion



            #region Homework





            string UserChoice = string.Empty;
            string degerEkle = string.Empty;
            string degerAra = string.Empty;
            string degerSil = string.Empty;
            string Ekleme = string.Empty;

            ArrayList valueList = new ArrayList();

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1-Deger Ekle");
                Console.WriteLine("2-Deger Listele");
                Console.WriteLine("3-Deger Ara");
                Console.WriteLine("4-Deger Duzenle");
                Console.WriteLine("5-Deger Sil");
                Console.WriteLine("6-Uygulama Çıkış");
                Console.Write("Seçiniz:");

                UserChoice = Console.ReadLine();

                

                switch (UserChoice)
                {


                    case "1":
                        Console.Write("degerinizi giriniz");
                        degerEkle = Console.ReadLine();
                        valueList.Add(degerEkle);
                        Console.WriteLine("deger eklenmiştir");
                        System.Threading.Thread.Sleep(2000); // sleep atıyor.
                        break;
                    case "2":
                        foreach (string item in valueList)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("devam etmek için bir tusa basınız");
                        Console.ReadLine();

                        break;
                    case "3":
                        Console.WriteLine("aramak istediginiz degeri giriniz");
                        degerAra = Console.ReadLine();
                        bool SearchResult=valueList.Contains(degerAra);
                        if (SearchResult)
                        {
                            int bulunanIndex = valueList.IndexOf(degerAra);
                            string bulunanDeger = valueList[bulunanIndex].ToString();
                            Console.WriteLine("aradıgınız deger {0} index, {1} degeri", bulunanIndex, bulunanDeger);
                        }else
                        {
                            Console.WriteLine("deger bulunamadı");
                        }
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(SearchResult);                      
                        break;
                    case "4":
                        Console.WriteLine("guncellemek istediginiz degeri giriniz");
                        string gelenDeger = Console.ReadLine();
                        if (valueList.Contains(gelenDeger))
                        {
                            int gelenDegerInd = valueList.IndexOf(gelenDeger);
                            valueList[gelenDegerInd] = gelenDeger;
                            Console.WriteLine("guncelleme isteginiz gerceklesti");

                        }else
                        {
                            Console.WriteLine("verdiğiniz deger listede bulunmuyor.");
                            Console.WriteLine("bu degeri listeye ekleyelim mi (E/H)");
                            Ekleme = Console.ReadLine();

                            if (Ekleme == "E")
                            {
                                valueList.Add(Ekleme);
                                Console.WriteLine("deger eklenmiştir");
                            }
                            else
                            {
                                Console.WriteLine("degeri eklemedik");
                            }
                        }
                        valueList.Sort();
                        break;
                    case "5":
                        Console.WriteLine("tum degerleri mi silmek istiyorsunuz: (E/H)");
                        string UserSil = Console.ReadLine();

                        if (UserSil.ToUpper() =="E")
                        {
                            valueList.Clear();
                            Console.WriteLine("Tum degerler silindi");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediginiz degeri giriniz");
                            string UserValueSil = Console.ReadLine();
                            if (valueList.Contains(UserValueSil))
                            {
                                valueList.Remove(UserValueSil);
                                Console.WriteLine("Silinmiştir");
                            }
                            else
                            {
                                Console.WriteLine("bu deger bulunmamaktadır.");
                            }
                        }
                        
                        break;
                    default:
                        break;
                }
            } while (UserChoice !="6");
            Console.WriteLine("Cıkısınız gerçeklesti");

            #endregion



            // Generic Collections
        }
    }
}
