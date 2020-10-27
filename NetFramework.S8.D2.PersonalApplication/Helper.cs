using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S7.D2.PersonalApplication
{
    public static class  Helper
    {
        // static olarak işaretlenmiş class lar örneklenemez.
        // static class ların içerisinde standart method da yazamasın.(static olmayan)
        // static classların içerisinde static olmayan field da oluşturamazsın.
        // static class ların içerisine constructive moethod olarak yine static kurabilirsin.

        static Helper() // constructive method
        {
            // uygulama boyunca 1 kez çalışırlar ancak public helper gibi constructive method yapabilseydik onlar her 
            // çağırıldıgında çalışırlar.
        }


        public static void emailSend(string RecieverEmailAdress,string topic,string content)
        {
            // email gonderme işlemleri devam edecek..

            Console.WriteLine("Mail sending is successfull");
        }
    }
}
