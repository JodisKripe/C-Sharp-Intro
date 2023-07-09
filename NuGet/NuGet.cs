using System;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using RestSharp;

class NuGet{
    public async static void run(){
        Console.WriteLine("Entering Nuget.cs");
        var client = new RestClient(new Uri("https://api.coingecko.com/api/v3/"));
        var req = new RestRequest("simple/price?ids=bitcoin&vs_currencies=GBP%2CINR");
        var resp = await client.GetAsync<Root>(req);
        Console.WriteLine("Current Bitcoin Price:");
        Console.WriteLine($"GBP: {resp.Bitcoin.Gbp}");
        Console.WriteLine($"INR: {resp.Bitcoin.Inr}");
    }
    internal class Bitcoin{
        [JsonPropertyName("gbp")] public double Gbp {get;set;}
        [JsonPropertyName("inr")] public double Inr {get;set;}
    }

    internal class Root{
        [JsonPropertyName("bitcoin")] public Bitcoin Bitcoin {get;set;}
    }
}