using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetFramework.S5.D3.SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            // data type of keys must be same and algorithm works as sorting key items.

            SortedList SortedL = new SortedList();

            SortedL.Add(100, "yuz");
            SortedL.Add(85, "seksenbes");
            SortedL.Add(70, "yetmis");
            SortedL.Add(10, "on");
            SortedL.Add(18, "onsekiz");

            #region Stack

            Stack S1 = new Stack(); // last in first out

            S1.Push("Bir");
            S1.Push("Iki");
            S1.Push("Uc");
            S1.Push("Dort");

            object O2 = S1.Peek(); // index 0 ı gosterir. datayı koleksiyondan çıkartmaz.
            object O1 = S1.Pop(); //index 0 ı gosterir. datayı koleksiyondan çıkarttı.
            

            #endregion

            #region Quee

            Queue Q1 = new Queue(); // first in first out

            Q1.Enqueue("Bir");
            Q1.Enqueue("Iki");
            Q1.Enqueue("Uc");
            Q1.Enqueue("Dort");

            object O3 = Q1.Peek();
            object O4 = Q1.Dequeue();

            #endregion


        }
    }
}
