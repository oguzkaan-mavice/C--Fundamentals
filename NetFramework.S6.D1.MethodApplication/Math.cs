using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S6.D1.MethodApplication
{
    public class Math
    {
        //sum
        public decimal SumFunc(decimal Num1, decimal Num2)
        {
            decimal result = Num1 + Num2;
            return result;
        }

        // diff

        public decimal DiffFunc(decimal Num1, decimal Num2)
        {
            decimal result = Num1 - Num2;
            return result;
        }

        // Divide

        public decimal DivideFunc(decimal Num1,decimal Num2)
        {
            decimal result = Num1 / Num2;
            return result;
        }

        //Multiply

        public decimal MultiplyFunc(decimal Num1, decimal Num2)
        {
            decimal result = Num1 * Num2;
            return result;
        }

        public void MenuCreate()
        {
            Console.Clear();
            Console.WriteLine("***Menu***");
            Console.WriteLine("1- Sum");
            Console.WriteLine("2- Diff");
            Console.WriteLine("3- Divide");
            Console.WriteLine("4- Multiply");
            Console.Write("Please choose a value");
        }

        public void resultPrint(decimal UserNum1, decimal UserNum2,decimal Result, string operators)
        {
            Console.WriteLine("{0} {1} {2} = {3}", UserNum1, operators, UserNum2, Result);
        }
    }
}
