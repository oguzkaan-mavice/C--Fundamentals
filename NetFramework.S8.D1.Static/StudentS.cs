using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D1.Static
{
    public class StudentS
    {
        
            public string Name { get; set; }
            public string Lastname { get; set; }
            public string EmailAdress { get; set; }

            public void Test1()
        {
            Console.Write("Nesne ornegi alındıktan sonra calısan method");
        }
            public void Test2()
        {
            Console.WriteLine("Nesne ornegi alınmadan kullanılan method");
        }
    }
}
