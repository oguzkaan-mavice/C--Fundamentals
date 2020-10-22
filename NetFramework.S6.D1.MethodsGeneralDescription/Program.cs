using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //libraries

namespace NetFramework.S6.D1.MethodsGeneralDescription
{
    class Program // packages
    {
        static void Main(string[] args) //methods
        {
            Hi();
            Student O1 = new Student();
            O1.StudentHi();
            O1.StudentMethod2();
        }

        static void Hi()
        {
            Console.WriteLine("Hello");
        }
    }
}
