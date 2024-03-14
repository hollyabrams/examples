using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using EasyPost.Models.API;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            EndShipper retrievedEndShipper = await client.EndShipper.Retrieve("es_...");

            Console.WriteLine(JsonConvert.SerializeObject(retrievedEndShipper, Formatting.Indented));
        }
    }
}
