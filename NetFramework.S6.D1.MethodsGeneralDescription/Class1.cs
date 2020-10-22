using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D1.MethodsGeneralDescription
{
    public class Student
    {
        public void StudentHi()
        {
            Console.WriteLine("Hi student");
        }

        /*
         * 
         * [Erişim belirleyicisi] <geri donus degeri> method adi(parametre)
         * {
         * }
         * 
         * Erişim belirleyicisi:
         * 
         * Public
         * Private
         * Protected
         * Internal
         * Internal Protected
         *
         * 
         */

        private void StudentMethod1(string StudentName, string StudentLastName)
        {
            Console.WriteLine("Student Info :  {0} {1}", StudentName, StudentLastName);
        }

        public void StudentMethod2()
        {
            StudentMethod1("Yekta", "Mavice");
        }
    }
}
