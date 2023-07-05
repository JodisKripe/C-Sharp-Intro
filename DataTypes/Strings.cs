using System;

class Strings{
    public static void run(){
        Console.WriteLine("\n\nStrings!!");
        string firstname = "Luffy";
        string lastname = "Johri";
        string fullname = $"{firstname} {lastname}";
        Console.WriteLine(fullname);
        string classicName = lastname + ", " + firstname;
        Console.WriteLine(classicName);
    }
}