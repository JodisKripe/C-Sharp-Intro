using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;
using System;


[Serializable]
internal class Person{
    [JsonPropertyName("first_name")] public string FirstName {get;set;}
    [JsonPropertyName("last_name")] public string LastName {get;set;}
    [JsonPropertyName("full_name")] public string FullName => $"{FirstName} {LastName}";
}

class Constraints{
    internal static byte[] SerializeObj<T>(T obj) where T: class{
        using var ms = new MemoryStream();
        JsonSerializer.Serialize(ms,obj);

        return ms.ToArray();
    }
    public static void run(){
        var person = new Person{
            FirstName="Luffy",
            LastName="Johri"
        };
        var json2 = SerializeObj(person);
        Console.WriteLine(Encoding.Default.GetString(json2));
    }
}