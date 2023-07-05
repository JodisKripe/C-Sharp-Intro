using System;
using System.Net;

class Enums{
    internal enum Status{
        Awesome,
        Sad
    }
    public static void run(){
        Console.WriteLine("ENUMS!!\n");
        var (firstname,lastname,status) = ("Luffy","Johri",Status.Awesome);
        switch(status){
            case Status.Awesome:
                Console.WriteLine($"{firstname} {lastname} is Awesome!!");
                break;
            case Status.Sad:
                Console.WriteLine($"{firstname} {lastname} is Sad");
                break;
            default:
                Console.WriteLine("Oops!!");
                break;
        }
    }
}