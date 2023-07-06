using System;

internal class Doggo{
    public string Name { get; set;}
    public double Age {get; set;}
    public string FavouriteGame {get; set;}
    public string prefix {get; init;}
    public string FullName => $"{prefix} {Name}";
    public Doggo(){

    }
    public Doggo(string Name, double Age, string FavouriteGame, string prefix){
        this.Name = Name;
        this.prefix = prefix;
        this.Age = Age;
        this.FavouriteGame = FavouriteGame;
    }
    public string RetName(){
        return FullName;
    } 
}

class Classes{
    public static void run(){
        Doggo[] doggos = new Doggo[4];
        doggos[0] = new Doggo{
            Name = "Luffy",
            Age = 2.67D,
            FavouriteGame = "Fetch",
            prefix = "Doggo"
        };
        doggos[1] = new Doggo{
            Name = "Zolu",
            Age = 5.2D,
            FavouriteGame = "Chase",
            prefix = "Doggie"
        };
        doggos[2] = new Doggo{
            Name = "Tyson",
            Age = 1.56D,
            FavouriteGame = "Tug",
            prefix = "Doggo"
        };
        doggos[3] = new Doggo("Bruh",1D,"Sleep","Pupper");
        foreach(Doggo doggo in doggos){
            Console.WriteLine($"{doggo.FullName} is {doggo.Age} years old and loves to play {doggo.FavouriteGame}");
        }
        Console.WriteLine(doggos[0].RetName());
    }
}