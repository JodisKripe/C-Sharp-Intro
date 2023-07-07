using System;
using System.Collections.Generic;
using System.Threading.Channels;
using System.Threading.Tasks;

class channels{
    public static async void run(){
        var channel = Channel.CreateUnbounded<string>();
        var task = Task.Run(async() =>
        {
            for(var i =0;i<10;i++){
                await channel.Writer.WriteAsync($"This is loop {i}");
            }
            channel.Writer.Complete();
        });
        while(!task.IsCompleted){
            try{
                var message = await channel.Reader.ReadAsync();
                Console.WriteLine(message);
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
        }
    }
}