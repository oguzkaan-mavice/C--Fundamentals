using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Customer C1 = new Customer();
            Customer C1 = new Customer("21232454232", "Furkan");
            C1.ID = "2233223387";
            C1.Name = "Kaan";
            C1.LastName = "Mavice";
            C1.Gender = 15940001;

            Customer C2 = C1;

            C2.Name = "Mahmut";
            C1.ID = "342349982";

            bool customerControl = C1.CustomerControl();

            C1=null;
            C2=null;

        }
    }
}
