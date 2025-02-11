using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
       internal class SumOfTwoNumbers
        {
            public static T Add<T>(T num1, T num2)
            {
                dynamic a = num1;
                dynamic b = num2;
                return a + b;
            }

            public void Display()
            {
                Console.WriteLine("Sum of integers : " + Add(10, 20));
                Console.WriteLine("Sum of doubles : " + Add(1.5, 2.3));
                Console.WriteLine("Sum of floats : " + Add(5.5f, 4.5f));
            }
        }
}


