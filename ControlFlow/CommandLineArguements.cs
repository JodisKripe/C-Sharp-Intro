using System;

class CommandLineArguements{
    public static void run(string[] args){
        Console.WriteLine("CLAAA!!\n");
        foreach(string arg in args){
            Console.WriteLine(arg);
        }
    }
}