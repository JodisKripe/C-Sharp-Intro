using System;

class ArraysAndTuples{
    public static void run(){
        Console.WriteLine("\n\nArrays and Tuples!!");
        int[] intArray = {1,2,3,4,5};
        int[] emptyArray = new int[5];
        emptyArray[2] = 52;
        Console.WriteLine("{0},{1},{2}\n",intArray[1],intArray[3],emptyArray[2]);
        (string, string, double) tuple231 = ("Luffy", "Johri", 2.5);
        Console.WriteLine("{0} {1} is {2} years old",tuple231.Item1,tuple231.Item2,tuple231.Item3);
    }
}