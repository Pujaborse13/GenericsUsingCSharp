using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
    internal class CompairDifferentDataTypeValues
    {
        public static void CompareValues<T1, T2>(T1 value1, T2 value2)
        {
            

            if (value1.Equals(value2))
            {
                Console.WriteLine($"Both values are Equal:{value1}");
            }
            else
            {
                Console.WriteLine($"Values are different : {value1} and {value2}");

            }
            
        }


        public void ComparerTwoValues()
        {

            int num1 = 10;
            double num2 = 10.0;
            Console.WriteLine("Comparing integer and double:");
            CompareValues(num1, num2);
            Console.WriteLine();

            string text1 = "Hello";
            string text2 = "Hello";
            Console.WriteLine("Comparing string and string:");
            CompareValues(text1, text2);
            Console.WriteLine();


            char char1 = 'A';
            int asciiValue = 65;
            Console.WriteLine("\nComparing char and ASCII value:");
            CompareValues(char1, asciiValue);

        }

    }

}
