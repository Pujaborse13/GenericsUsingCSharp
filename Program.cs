using GenericsUsingCSharp;

class Program
{
    static void Main(string[] args)
    {

        //Print Array Data 
        PrintArrayData printArrayData = new PrintArrayData();
        PrintArrayData.ToPrint(printArrayData.inArr);
        Console.WriteLine();

        PrintArrayData.ToPrint(printArrayData.doubleArr);
        Console.WriteLine();

        PrintArrayData.ToPrint(printArrayData.charArr);
        Console.WriteLine();

        PrintArrayData.ToPrint(printArrayData.stringArr);
        Console.WriteLine();


        //Swap Two Variables 
        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();   
        swapTwoNumbers.SwapTwoVariables();



    }
}   