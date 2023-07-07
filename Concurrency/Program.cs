using System;
using System.Threading.Tasks;

var t1 = Task.Run(LOOP);
var t2 = Task.Run(LOOP);
await Task.WhenAll(t1,t2);
Console.WriteLine($"{t1}\t\t{t2}");
ThreadingCode.run();
ParallelCode.run();
    // await Task.WhenAll(t1,t2);
int LOOP(){
    int i;
    for (i=11;i<20;i++)Console.WriteLine(i);
    return i;
}