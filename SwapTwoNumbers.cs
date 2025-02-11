using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
    internal class SwapTwoNumbers
    {

        public static void SwapTwoNum<T>(ref T a, ref T b)
        { 
           T temp = a;
           a = b;
           b = temp;

        }

        public void SwapTwoVariables()
        {
            int num1 = 10, num2 = 20;
            Console.WriteLine($"Before Swap: num1 = {num1}, num2 = {num2}");
            SwapTwoNum(ref num1, ref num2);
            Console.WriteLine($"After Swap: num1 = {num1}, num2 = {num2}");

            Console.WriteLine();

            string s1 = "puja" ,  s2 = "asmita";
            Console.WriteLine($"Before swap: s1 = {s1} , s2 = {s2}");
            SwapTwoNum(ref s1, ref s2);
            Console.WriteLine($"After Swap : s1 ={s1} , s2 ={s2}");
             



        }
    }
}
