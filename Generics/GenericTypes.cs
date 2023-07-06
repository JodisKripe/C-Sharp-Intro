using System.Collections.Generic;
using System;

internal class Person{
    public string Name {get;set;}
}

class GenericTypes{
    public static void run(){
        var people = List<Person>();
    }
}