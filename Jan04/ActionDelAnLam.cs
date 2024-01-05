using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan04
{
    internal class ActionDelAnLam
    {
        public static void A_PrintName(string name)
        {
            Console.WriteLine("Hello Good Morning " + name);
        }
        public static void A_PrintName()
        {
            Console.WriteLine("Hello Good Morning All");
        }
        public static void AddingNumbers(double num1, double num2) { Console.WriteLine("the result is  " + (num1 + num2)); }
        static void Main(string[] args)
        {

            Action<double, double> A_adding = AddingNumbers;
            A_adding.Invoke(9.9, 5.5);
            Action<string> act1 = A_PrintName;// generic action calling line 10
            Action act = A_PrintName;//non generic  line 12 
            A_PrintName();// non generic 
                          // act1("Mphasis");// generic 
                          // anonymous method
            Action<double, double> any_Adding = delegate (double num1, double num2) { Console.WriteLine("the result is  " + (num1 + num2)); };
            // any_Adding(3.5, 4.5);
            //lambda expression
            Action<double, double> lam_Adding = (num1, num2) =>
            {
                Console.WriteLine("result with action Lambda " + (num1 + num2));
            };
            //  lam_Adding(3.5, 4.5);
        }
    }
}
   
