using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
internal class Person{
    public string FirstName {get;init;}
    public string LastName {get;init;}
    public string FullName => $"{FirstName} {LastName}";
    public DateOnly DateOfBirth {get;init;}
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

}

class linq{
    public static void run(){
        try{
            var people = new List<Person>{
            new(){FirstName = "Lebron", LastName = "James", DateOfBirth = new DateOnly(year:1957,month:2,day:3)},
            new(){FirstName = "Steph", LastName = "Curry", DateOfBirth = new DateOnly(year:1972,month:11,day:22)},
            new(){FirstName = "LaMelo", LastName = "Ball", DateOfBirth = new DateOnly(year:1993,month:5,day:17)},
            new(){FirstName = "Chris", LastName = "Paul", DateOfBirth = new DateOnly(year:1986,month:11,day:1)},
            new(){FirstName = "Giannis", LastName = "Antetokoumpo", DateOfBirth = new DateOnly(year:1979,month:7,day:26)}
            };
            var persons = people.Where(p => p.DateOfBirth.Year > 1975).ToArray();
            Console.WriteLine($"Found {persons.Length} people. They are:");
            foreach(var person in persons){
                Console.WriteLine($"{person.FullName}, born on {person.DateOfBirth}, age {person.Age}.");
            }
            Console.WriteLine("Sit1");
            var sit1 = people.Where(p => p.Age <= 50 && p.DateOfBirth.DayOfWeek == DayOfWeek.Monday).ToArray();
            Console.WriteLine($"Found {sit1.Length} people. They are:");
            foreach(var person in sit1){
                Console.WriteLine($"{person.FullName}, born on {person.DateOfBirth}, age {person.Age}.");
            }

            if(!people.Any(p => p.Age<20))
                Console.WriteLine("No people under 20 here!!");
            Console.WriteLine(people.First(p => p.FirstName.StartsWith("L")).FullName);
            Console.WriteLine(people.FirstOrDefault(p => p.FirstName.StartsWith("Y")) is null ? "No such person found" : people.FirstOrDefault(p => p.FirstName.StartsWith("L")).FullName);
            var ascending = people.OrderBy(p => p.Age).ToArray();
            var descending = people.OrderByDescending(p => p.Age).ToArray();
            foreach(Person person in ascending)
                Console.WriteLine($"{person.FullName}");
            foreach(Person person in descending)
                Console.WriteLine($"{person.FullName}");
        }
        catch(Exception e){
            Console.WriteLine("ERRORORORO"+e);
        }
        
    }
}