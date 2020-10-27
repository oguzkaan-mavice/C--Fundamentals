using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.Encapsulation
{
    internal class Customer
    {

        public Customer()
        {
            this.ID = IdGenerate();  //1- create ctor. 2- create private method that is used in ctor. 3- create public get-set block.
            // 4- private id should be return inside of get and privated id should be referred to value inside of set.
        }



        //class --> Field
        private int ID;
        public string Name;
        public string LastName;

        public int id
        {
            get
            {
                return this.ID;
            }
            private set // beacuse of private status; field can be read but cannot be assigned.
            {
                this.id = value;
            }
        }

        private int IdGenerate()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 80000);
        }


        private string emailadress; // because of private status, you cannot recall it in the program.cs to add value its inside. 
        //Therefore we should create property to provide adding value process in outside this class

        //class -->Property
        public string EmailAdress
        {
            // get; //the part that display data
            // set; // the part that is sending value which is assigned outside of this class to keep inside of above private field.

            set
            {
                this.EmailAdress = value;
            }
            get 
            {
                return this.emailadress; // field both can be read and can be assigned.
            }

        }



    }
}
