using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S5.D2.Collections.HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            H1.Add("Car","Araba"); // key degerleri primary key
            H1.Add("House", "Ev");


            bool Control1=H1.Contains("House"); // Key degerini yazarsın.
            bool Control2 = H1.ContainsKey("House");
            bool Control3 = H1.ContainsValue("Araba"); // value değerini yazarsın.

            int CollectionsSum=H1.Count;

            H1.Remove("Car"); // key degeri yazarsın

            H1["Car"] = "Taşıt";

            H1.Clear();

            #region Homework

            Hashtable dictionary = new Hashtable();
            string Key1 = string.Empty;
            string Value1 = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("write value to add");
                Console.Write("EN : ");
                Key1 = Console.ReadLine();

                bool controlEN = dictionary.ContainsKey(Key1);

                if (controlEN)
                {
                    Console.WriteLine("the value ,{0}, you want to add has already in dictionary, its turkish translation is : {1}"
                        , Key1, dictionary[Key1].ToString());
                }
                else
                {
                    Console.WriteLine("write turkish meaning of {0} ", Key1);
                    Value1 = Console.ReadLine();
                    dictionary.Add(Key1, Value1);
                    Console.WriteLine("Adding process was be successfull");
                }



                Console.WriteLine("do you want to add new values? E/H");
            } while (Console.ReadLine().ToUpper()!="H");

            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(" ENG: {0} = TR :{1}", item,dictionary[item]);
            }

            // alternative way
            foreach (DictionaryEntry item in dictionary)
            {
                //Console.WriteLine(item.GetType().Name);
                Console.WriteLine("ENG : {0} = TR : {1}", item.Key, item.Value);
            }
            #endregion

        }
    }
}
