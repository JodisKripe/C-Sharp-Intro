using System;

class Bitwise{
    public static void run(){
        Console.WriteLine("\n\nBitWise!!");
        var rand = new Random();
        var i1 = rand.Next(0,100);
        var i2 = rand.Next(0,100);
        Console.WriteLine($"i1:{i1}\ti2:{i2}");
        Console.WriteLine(i1 & i2);
        Console.WriteLine(i1 | i2);
        Console.WriteLine(i1 ^ i2);
        Console.WriteLine(i1 << i2);
        Console.WriteLine(i1 >> i2);

    }
}