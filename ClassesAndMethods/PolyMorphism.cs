using System;

internal class Animal{
    public string species {get; set;}
}

internal class Dog : Animal{
    public string Name {get;set;}
    public string species => "Dog";
}

class PolyMorphism{
    public static void run(){
        Animal A1 = new Animal{
            species = "Lion"
        };
        Dog D1 = new Dog{
            Name = "Luffy"
        };
        Console.WriteLine($"{A1.species}");
        Console.WriteLine($"{D1.Name} : {D1.species}");
    }
}