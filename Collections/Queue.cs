using System;
using System.Collections;
using System.Collections.Generic;

class Qu{
    public static void run(){
        Console.WriteLine("\n\nQueue!!");
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        while(queue.TryDequeue(out var value))
            Console.WriteLine(value);
        Console.WriteLine("Stack!!\n\n");
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        while ( stack.TryPop(out var value))
            Console.WriteLine(value);
    }
}