using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class Person{
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public string FullName {get;set;}
    public Person(string FullName){
        this.FullName = FullName;
    }
}
class ParallelCode{
    public static void run(){
        var people = new List<Person>();
        people.Add(new Person("Lebron James"));
        people.Add(new Person("Steph Curry"));
        people.Add(new Person("Giannis Antetokoumpo"));
        people.Add(new Person("Lamelo Ball"));
        Parallel.ForEach(people,PrintPerson);
    }
    static void PrintPerson(Person person){
        Console.WriteLine($"{person.FullName}");
    }
}