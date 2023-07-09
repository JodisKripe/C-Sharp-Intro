using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


internal class Program
{
    static List<item> Todo = new List<item>();
    private static void Main(string[] args)
    {   
        Console.WriteLine("Hello, Welcome to your todo-list !");
        while(true){
            Console.WriteLine("\nPlease enter the Action:\n1) Add an Item\n2) Delete an Item\n3) Fetch Items.");
            var choice = Console.ReadLine();
            switch(choice){
                case "1":
                    AddItem();
                    break;
                case "2":
                    DeleteItem();
                    break;
                case "3":
                    InteractWithItems();
                    break;
                default:
                    Console.WriteLine("Please Enter a valid value!!");
                    break;
            }
        }
    }
    internal static void AddItem(){
        Console.Write("Enter Title: ");
        var itemTitle = Console.ReadLine();
        Console.Write("Enter Body: ");
        var itemBody = Console.ReadLine();
        item I1 = new item{title=itemTitle,body=itemBody};
        Todo.Add(I1);
    }
    internal static void InteractWithItems(){
        foreach(item I in Todo){
            Console.WriteLine($"{I.title}");
            Console.WriteLine($"{I.body}\n");
        }
    }

    internal static void DeleteItem(){
        Console.Write("Enter the title of the Item you want to delete: ");
        var delTitle = Console.ReadLine();
        foreach(item I2 in Todo.Where(ITEM => ITEM.title == delTitle )){    
            item delItem = new item{title=I2.title,body=I2.body};
            Todo.Remove(delItem);
        }
        //Todo.Remove(I1);
    }
}

internal class item{
    public string title {get;set;}
    public string body {get;set;}
}