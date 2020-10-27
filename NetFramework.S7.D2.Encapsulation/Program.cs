using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer C = new Customer();
            C.id = "12"; // cannot be assigned becasue set part is private in customer class
            C.Name = "Kaan";
            C.LastName = "Mavice";

            C.EmailAdress="kaan.mavice@gmail.com";

            /* Encapsulation usage;
             * 
             * Field value can be read but cannot be assigned any value
             * Field value cannot be read but can be assigned any value
             * Field value can be read and assigned but for example first 3 digits can be read
             * Field value can be read and assigned but after the some processes which are determined by us
             */
        }
    }
}
