using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.PersonalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal P1 = new Personal();

            P1.Name = "Kaan";
            P1.Lastname = "Mavice";
            P1.emailadress = "kaan.mavice";
            P1.gender = 100010001;

            Helper.emailSend("ik@firmam.com", "New personal welcome", P1.Name + P1.Lastname); // helper methodunu orneklemeden kullanabildim.

            // static class ların nesne ornegi alınmaz.




        }
    }
}
