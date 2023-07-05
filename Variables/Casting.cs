using System;

class Casting{
    public static void run(){
        Console.WriteLine("\n\nCasting!!");
        var i5 =20;
        double newDouble = i5;
        Console.WriteLine(newDouble);
        double d2 = 3.14156D;
        int i1 = (int)d2;
        Console.WriteLine(i1);
        var c = 'A';
        int i = c;
        Console.WriteLine($"{c} == {i}");
        c = (char)i;
        Console.WriteLine($"{c} == {i}");
    }
}