using System;
using System.Threading.Tasks;

class TaskCode{
    public async static void run(){
        var t1 = await Task.Run(LOOP);
        var t2 = await Task.Run(LOOP);
        Console.WriteLine($"{t1}\t\t{t2}");
        // await Task.WhenAll(t1,t2);
    }
    internal static int LOOP(){
        int i;
        for (i=11;i<20;i++)Console.WriteLine(i);
        return i;
    }
}