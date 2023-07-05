using System;

class IfElse{
    public static void run(){
        var rand = new Random();
        int i1 = rand.Next(0,10);
        int i2 = rand.Next(0,10);
        if(i1<i2){
            Console.WriteLine($"{i1}<{i2}");
        }
        else{
            Console.WriteLine($"{i1}>={i2}");
        }
    }
}