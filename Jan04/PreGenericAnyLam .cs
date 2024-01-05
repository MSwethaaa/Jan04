using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan04
{
    public class PreGenericAnyLam
    {
        // public static bool IsEvenNumber(int num1) { if (num1 % 2 == 0) return true; return false; }
        static void Main(string[] args)
        {
            //Predicate<int> pre_CheckEven = IsEvenNumber;// address is stored in pre_CheckEven
            //bool res = pre_CheckEven(10);
            //Console.WriteLine(res);
            // Predicate<int> pre_anMethodPointer = delegate (int num1) { if (num1 % 2 == 0) return true; return false; };
            //bool res =  pre_anMethodPointer.Invoke(15);// pre_anMethodPointer(15);
            // Console.WriteLine(res);
            // lamdba expression
            Predicate<int> preLam = (num1) => { if (num1 % 2 == 0) return true; return false; };
            bool res = preLam.Invoke(20);
            Console.WriteLine(res);
            Action<int> a;
            Action aa;




        }
    }
}

   
