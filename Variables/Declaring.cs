using System;

class Declaring{
    public static void run(){
        Console.WriteLine("Decalring!!");
        var t1 = ("Luffy","Johri",2.5F);
        Console.WriteLine("{0} {1} is {2} years old.",t1.Item1,t1.Item2,t1.Item3);
        const double bruh = 2.5433677D;
        Console.WriteLine(bruh);
    }
}