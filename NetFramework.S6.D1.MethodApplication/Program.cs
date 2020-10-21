using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D1.MethodApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Math M = new Math();
            AgainUseFunctions:
            M.MenuCreate();
            int UserPrefer = int.Parse(Console.ReadLine());



            Console.WriteLine("Please enter the your first number");
            decimal UserNum1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the your second number");
            decimal UserNum2 = decimal.Parse(Console.ReadLine());

            decimal result = 0;

            switch (UserPrefer)
            {
                case 1:
                    result=M.SumFunc(UserNum1, UserNum2);
                    M.resultPrint(UserNum1, UserNum2, result, "+");
                    break;
                case 2:
                    result = M.DiffFunc(UserNum1, UserNum2);
                    M.resultPrint(UserNum1, UserNum2, result, "-");
                    break;
                case 3:
                    result = M.DivideFunc(UserNum1, UserNum2);
                    M.resultPrint(UserNum1, UserNum2, result, "/");
                    break;
                case 4:
                    result = M.MultiplyFunc(UserNum1, UserNum2);
                    M.resultPrint(UserNum1, UserNum2, result, "*");
                    break;
                default:
                    Console.WriteLine("Your preference is not in menu");
                    Console.WriteLine("Please, try again");
                    System.Threading.Thread.Sleep(2000);
                    goto AgainUseFunctions;
            }

            Console.WriteLine("Do you want to make another operation? E/H");
            string EH = Console.ReadLine();
            if (EH=="E")
            {
                goto AgainUseFunctions;
            }
        }
    }
}
