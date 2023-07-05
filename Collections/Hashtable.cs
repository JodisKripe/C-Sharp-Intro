using System;
using System.Collections;

class HashTable{
    public static void run(){
        var table = new Hashtable{
            {0,"Tiger"},
            {1,"Leopard"},
            {2,"Panther"},
            {3,"Lion"}
        };

        foreach(DictionaryEntry entry in table)
            Console.WriteLine($"{entry.Key} : {entry.Value}");
    }
}