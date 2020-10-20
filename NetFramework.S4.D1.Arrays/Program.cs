using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S4.D1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentList = new string[5]; // create string arrays

            // index starts wtih 0 not 1

            studentList[0] = "Kaan";
            studentList[1] = "Oguz";
            studentList[2] = "Yekta";
            studentList[3] = "Lale";
            studentList[4] = "Mahmut";

            //Console.WriteLine(studentList[2]);

            #region write all elements in array -- foreach and for

            foreach(string item in studentList)
            {
                Console.WriteLine(item);

            }

            for(int i=0;i<studentList.Length;i++)
            {
                string Names = studentList[i];
                Console.WriteLine(Names);
            }
            #endregion

            #region Example 1 


            Console.WriteLine("Please give me a length for array");
            string arrayLength = Console.ReadLine();
            int arrayLengthInt = int.Parse(arrayLength);

            int[] array1 = new int[arrayLengthInt];

            for (int counter=0; counter<array1.Length; counter++)
            {
                Console.WriteLine("write {0}. index value ", counter);
                array1[counter] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Congrululations, fill up all items in array");

            Console.WriteLine("Items and calculation are like above");

            int Summary = 0, Avg = 0;
            foreach(int item in array1)
            {
                Console.WriteLine(item);
                Summary = Summary + item;
                
            }
            Console.WriteLine("******************************");
            Console.WriteLine("Summary is {0}", Summary);
            Avg = Summary / array1.Length;
            Console.WriteLine("Avg is {0}", Avg);

            #endregion

            #region Example 2

            int[] IntListX = new int[20];
           
            int sum_for_4 = 0;
            Random Rnd = new Random();

            /*foreach(int item in IntListX)
            {
                
                Random rnd = new Random();
                IntListX[item] = rnd.Next(1, 10);
               
            }*/

            for (int i = 0; i < IntListX.Length; i++)
            {
                //Random rnd = new Random();
                IntListX[i] = Rnd.Next(1, 10);
            }

            foreach(int item in IntListX)
            {
                Console.WriteLine(item);
            }

            for (int i =0; i < IntListX.Length; i++)
            {
                if(i==4)
                {
                    sum_for_4++;
                }
            }
            Console.WriteLine("{0} items are founded in the array", sum_for_4);
            #endregion
        }
    }
}
