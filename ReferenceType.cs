using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S1.D2.ReferrenceTypeBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            Car cardefinition1 = new Car();
            cardefinition1.brand = "Opel";
            cardefinition1.model = "Corsa";
            cardefinition1.colour = "Blue";

            Car cardefinition2 = cardefinition1;

            cardefinition2.colour = "Red";
            cardefinition2.model = "Astra";
            // cardefinition 2 ile cardefinition 1 ortak referans gösterdiğinden
            // definition2 deki değişiklik ile definition 1 i de değiştirdim.
            // çünkü bu iki tanımlama heap bölümünde ortak bir referansa gidiyor.


        }
    }

    class Car
    {
        public string brand;
        public string model;
        public string colour;

    }
}
