using System;
using System.Collections.Generic;

class Lists{
    public static void run(){
        Console.WriteLine("Lists!!");
        var list1 = new List<int>();
        var list2 = new List<int> {1,2,3,4,5};
        list2.Add(item:6);
        list2.Add(item:7);
        list2.Add(item:8);
        list2.Add(item:9);
        list2.Add(item:10);
        Console.WriteLine($"{list2[8]}");
        list2.Remove(item:1);
        list2.RemoveAt(index:1);
        Console.WriteLine("\n");
        foreach(var i in list2)
            Console.WriteLine(i);
        if(list2.Contains(item:6))
            Console.WriteLine("It has 6");
        var item = list2.Find(v => v == 2);
        Console.WriteLine(item);
        // Note that if the value does not exist, the method returns the default value for the list's data type, T.  Another aspect to watch out for is that a list does allow you to add the same value multiple times, and methods such as Remove, Find, and IndexOf return the first occurrence of that data.
    }
}