using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D2.RefOutUsage
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num1 = 0;
            ValueRef(ref Num1); // Num1 value is referred by below ValueRef method and ValueMark value 
            SumAll(5, 4, 3, 2, 6, 34, 23, 6);
        }

     static void ValueRef(ref int ValueMark)
        {
            ValueMark = 10;
        }
        static void SumAll(params int[] numbers) // parameters you enter are converted to list
        {
            int SumValues = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                SumValues += numbers[i];
            }

            Console.WriteLine("Sum {0}:", SumValues);
        }
    }
}
