class Program
{

    static void Main(string[] args)
    {

        int[] inArr = { 1, 2, 3, 4, 5, };
        char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
        double[] doubleArr = { 1.0,1.2,1.3,1.4,1.5};
        string[] stringArr = { "puja","disha","asmita","komal","mani"};

        ToPrintInt(inArr);
        ToPrintDouble(doubleArr);
        ToPrintChar(charArr);
        ToPrintString(stringArr);
        
    }


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