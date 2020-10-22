using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D1.OOP
{
    public class Customer
    {
        /*
         * ID
         * Name
         * LastName
         * Gender
         */

        //constructive method

        public Customer()
        {
            ID = "1234345323";
        }

        public Customer(string _ID,string _Name)
        {
            ID = _ID;
            Name = _Name;
        }

        public Customer(string _ID,string _Name, string _LastName)
        {
            ID = _ID;
            Name = _Name;
            LastName = _LastName;

        }

        public string ID;
        public string Name;
        public string LastName;
        public int Gender;

        public bool CustomerControl()
        {
            bool control = CustomerControlDB(ID);
            return control;
        } 

        private bool CustomerControlDB(string ID)
        {
            return true;
        }
    }
}
