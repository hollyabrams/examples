using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyPost;
using Newtonsoft.Json;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            List<CarrierType> carrierTypes = await client.CarrierType.All();

            Console.WriteLine(JsonConvert.SerializeObject(carrierTypes, Formatting.Indented));
        }
    }
}
