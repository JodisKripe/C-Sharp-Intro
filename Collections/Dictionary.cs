using System;
using System.Collections.Generic;

class Dictionary{
    public static void run(){
        var dict = new Dictionary<int, string>();
        dict.Add(0,"Panther");
        dict.Add(1,"Tiger");
        dict.Add(2,"Lion");

        foreach(var kvp in dict)
            Console.WriteLine($"\nKey: {kvp.Key}\nValue: {kvp.Value}\n");
        if (dict.TryGetValue(1, out var value))
            Console.WriteLine(value);
        if (dict.ContainsKey(2))
            dict[2] = "Leopard";
        Console.WriteLine(dict[2]);
    }
}