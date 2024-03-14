using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            Event @event = await client.Event.Retrieve("evt_...");

            Console.WriteLine(JsonConvert.SerializeObject(@event, Formatting.Indented));
        }
    }
}
