using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan04
{
    public class TestPointer
    {
        unsafe static void Main(string[] args)
        {

            int num1 = 100;
            int* xPointer = &num1;
            //Console.WriteLine(" the values of {0} is  ", num1,xPointer);
            Console.WriteLine("the address of num1 {0} ", (int)xPointer);
            Console.ReadLine();
            //unsafe
            //{
            //    int num1 = 100;
            //    int* xPointer = &num1;
            //    Console.WriteLine(" the values of {0} is  ", num1);
            //    Console.WriteLine("the address of num1 {0} ",(int)xPointer);

            //    Console.ReadLine();
            //}
        }
    }
}

   
