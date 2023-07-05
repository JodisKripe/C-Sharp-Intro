using System;

class Switch{
    public static void run(){
        Console.WriteLine("SWITCH!!\n");
        var animal = Console.ReadLine();
        var sound = animal switch{
            "Dog" => "Woof",
            "Cat" => "Meow",
            _ => "Unknown"
        };
        Console.WriteLine(sound);
    }
}