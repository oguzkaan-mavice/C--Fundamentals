using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.PersonalApplication
{
    public class Personal
    {
        public static string DomainAdress = "firmam.com";

        public string Name { get; set; }
        public string Lastname { get; set; }

        private string _emailadress;
        public string emailadress
        {
            get
            {
                return this._emailadress;
            }
            set
            {
                this._emailadress = value.ToLower() + "@" + Personal.DomainAdress;
            }
        }

        public int gender { get; set; }
    }
}
