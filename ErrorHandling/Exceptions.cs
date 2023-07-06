using System;

class Exceptions{
    public static void run(){
        var array = new[] {1,2,3,4,5};

        try{
            Console.WriteLine(array[5]);
        }
        catch(IndexOutOfRangeException e){
            Console.WriteLine($"NOPE {e}");
        }
        catch(Exception e){
            Console.WriteLine($"Nope {e}");
        }
        Console.WriteLine("Yup, Still Got it.");
    }
}