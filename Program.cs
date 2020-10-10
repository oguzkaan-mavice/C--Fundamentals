using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D1.TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {



            byte sayi1 = byte.MaxValue;
            sayi1 = byte.MinValue;
            //bilincli tür donusumu

            int sayi2 = 125;
            sayi1 = (byte)sayi2;

            Console.WriteLine(sayi1);

            //bilincsiz tur donusumu

            double sayi3 = 10;
            sayi3 = sayi2;

            Console.WriteLine(sayi3);

            //checked - unchecked

            // eğer donusumde değer, deger kaybına uğrayacaksa; orneğin
            // double'dan int'e veya yine sınırları dışında olmak uzere
            // int'ten byte donerken kapsam dısında kalma durumu olursa deger kaybı olur.

            unchecked
            {
                sayi2 = 512;

                sayi1 = (byte)sayi2;
            }
           /* checked // deger kaybı yasadığında hata vermesi için
            {
                sayi2 = 512;

                sayi1 = (byte)sayi2;

            } */
            // object

            object temeltip = sayi2;
            temeltip = sayi3;
            temeltip = new
            {
                brand = "Opel",
                model = "Corsa",

            };

            // Boxing işlemi

            temeltip = sayi2; // boxing işlemi 
            sayi2 = (int)temeltip;//unboxing işlemi
  


        }
    }
}
