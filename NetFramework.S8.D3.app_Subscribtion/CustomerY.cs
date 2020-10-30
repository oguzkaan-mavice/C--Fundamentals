using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S8.D3.GeneralTest2
{
    class CustomerY
    {

        #region Virtual Database

        static ArrayList Database;

        #endregion

        #region ArrayList Constructive Method

        public CustomerY()
        {
            Database = new ArrayList();
        }
        #endregion

        #region public field

        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        
        public string Password { get; set; }



        #endregion region

        #region encapculation

        private string UserName { get; set; }
        public string _UserName
        {
            get 
            {
                return this._UserName;
            } set
            {
                bool userNameControl = UserAddControl(value);
                if (userNameControl)
                {
                    Console.WriteLine("your marked user name is already be suscribed");
                    this._UserName = string.Empty;
                }
                else
                {
                    this._UserName = value;
                }
            }
        }




        private string email;
        public string _email { get; set; }


        #endregion

        #region emailcontrol static method

        public static void UserEmail(CustomerY M)
        {
            if (M != null && !string.IsNullOrEmpty(M.UserName) && !string.IsNullOrEmpty(M.email))
            {
                bool emailControl = EmailControl(M.email);
                if (emailControl)
                {
                    Console.WriteLine("the email adress you want to add is already suscribed");
                }
                else
                {
                    Database.Add(M);
                    Console.WriteLine("New suscribtion process is successfull");
                }
            }
        }



        #endregion


        #region user add static method

        static bool UserAddControl(string _UserName)
        {
            bool control = false;
            for (int i = 0; i < Database.Count; i++)
            {
                CustomerY temp = (CustomerY)Database[i];
                if (temp.UserName==_UserName)
                {
                    control = true;
                    break;
                }


            }
            return control;
        }



        #endregion



        static bool EmailControl(string _email)
        {
            bool control = false;
            for (int i = 0; i < Database.Count; i++)
            {
                CustomerY temp = (CustomerY)Database[i];
                if (temp.email==_email)
                {
                    control = true;
                    break;
                }
            }
            return control;
        }
    }
}
