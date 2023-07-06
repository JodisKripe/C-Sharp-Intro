using System;

internal abstract class Employee{
    public string Name {get;set;}
    public void MyName(){
        Console.WriteLine("I am an Employee!!!");
    }
    public abstract void angy();
}

internal class Admin : Employee{
    public void MyName(){
        Console.WriteLine("I am an Admin!!!");
    }
    public override void angy(){
        Console.WriteLine("I am angy T-T");
    }
}

internal class Manager : Employee{
    public void MyName(){
        Console.WriteLine("I am a Manager!!!");
    }
    public override void angy(){
        Console.WriteLine("I am not angy :)");
    }
}
class Abstraction{
    public static void run(){
        Admin A1 = new Admin{Name = "Mark"};
        Manager M1 = new Manager{Name = "Rick"};
        A1.MyName();
        M1.MyName();
        A1.angy();
        M1.angy();
    }
}