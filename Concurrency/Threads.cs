using System;
using System.Threading;

class ThreadingCode{
    public static void run(){
        var t1 = new Thread(LOOP);
        var t2 = new Thread(LOOP);
        var t3 = new Thread(LOOP){
            IsBackground = true
        };
        t1.Start();
        t2.Start();
        t3.Start();
    }
    internal static void LOOP(){
        for(int i=0;i<10;i++)Console.WriteLine(i);
    }
}