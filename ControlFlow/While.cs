using System;

class While{
    public static void run(){
        Console.WriteLine("While!!!\n");
        int counter = 5;
        while(counter < 10){
            Console.WriteLine(counter);
            counter++;
        }
    }
}