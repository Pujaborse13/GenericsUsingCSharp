using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsUsingCSharp
{
    internal class MinMaxOfThreeNumber
    {

        public static T FindMax<T>(T n1, T n2, T n3) where T : IComparable
        {

            T max = n1;

            if (n2.CompareTo(max) > 0)
            {
                max = n2;
            }

            if (n3.CompareTo(max) > 0)
            {
                max = n3;

            }

            return max;
        }

        public static T FindMin<T>(T n1, T n2, T n3) where T : IComparable 
         {
             T min = n1;

            if(n2.CompareTo(min) < 0)

            {
                min = n2;
                
            }

            if (n3.CompareTo(min) < 0)
            {
                min = n3;    
            }
            return min;
        }


        public void FindMinMax()
        {
            Console.WriteLine("Maximum of 10, 20, 5: " + FindMax(10, 20, 5));
            Console.WriteLine("Maximum of 10, 20, 5: " + FindMin(10, 20, 5));


            Console.WriteLine("Maximum of 1.2, 3.4, 2.5: " + FindMax(1.2, 3.4, 2.5));
            Console.WriteLine("Minimum of 1.2, 3.4, 2.5: " + FindMin(1.2, 3.4, 2.5));

            Console.WriteLine("Maximum of 'apple', 'banana', 'peach': " + FindMax("apple", "banana", "peach"));
            Console.WriteLine("Minimum of 'apple', 'banana', 'peach': " + FindMin("apple", "banana", "peach"));




        }



    }

}




        





            
        
        
