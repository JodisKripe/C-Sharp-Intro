using System;

class Logical{
    public static void run(){
        Console.WriteLine("\n\nLogical!!");
        var rand = new Random();
        var i1 = rand.Next(0,100);
        var i2 = rand.Next(0,100);
        Console.WriteLine($"i1:{i1}\ti2:{i2}");
        if(i1<i2) Console.WriteLine("i1 is less than i2");
        if(i1>i2) Console.WriteLine("i1 is more than i2");
        if(i1==i2) Console.WriteLine("i1 is equal to i2");
        if(i1<=i2) Console.WriteLine("i1 is less than equal to i2");
        if(i1>=i2) Console.WriteLine("i1 is more than equal to i2");
        if(i1!=i2) Console.WriteLine("i1 is not equal to i2");
    }
}