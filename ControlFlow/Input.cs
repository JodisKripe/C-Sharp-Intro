using System;

class Input{
    public static void run(){
        while(true){
            Console.Write("Input Please > ");
            var choice = Console.ReadLine();
            if(choice==null){break;}
            if(choice.Equals("exit",StringComparison.OrdinalIgnoreCase)){
                break;
            }
            switch(choice){
                case "Y":
                    Console.WriteLine("YESS!!!");
                    break;
                default:
                    Console.WriteLine("NOOO!!");
                    break;
            }
        }
    }
}