using System;

class For{
    public static void run(){
        Console.WriteLine("FOR!!\n");
        for(int i = 0;i<10;i++){
            Console.WriteLine(i);
        }
        var list = new List<int> {1,2,3,4,5,6,7,8};
        foreach(int I in list){
            Console.WriteLine(I);
        }
    }
}