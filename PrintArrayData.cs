using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
    internal class PrintArrayData
    {

       public int[] inArr = { 1, 2, 3, 4, 5, };
       public char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
       public double[] doubleArr = { 1.0, 1.2, 1.3, 1.4, 1.5 };
       public string[] stringArr = { "puja", "disha", "asmita", "komal", "mani" };
        
        //Using Generic 
        public static void ToPrint<T>(T[] array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);

            }

        }


        /*
        //Without Generics
        public static void ToPrintInt(int[] intArray)
        {
            foreach (int element in intArray)
            {
                Console.WriteLine(element);

            }

        }

        public static void ToPrintChar(char[] charArr)
        {
            foreach (int element in charArr)
            { 
                Console.WriteLine(element);

            }
        }


        public static void ToPrintDouble(double[] doubleArr)
        {
            foreach (double element in doubleArr)
            { 
                Console .WriteLine(element);
            }
        }


        public static void ToPrintString(string[] StringArr)
        {
            foreach (string element in StringArr)
            {
                Console.WriteLine(element);
            }
        }
        }

            */
    }
}
