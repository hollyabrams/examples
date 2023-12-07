using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;
using EasyPost.Models.API;
using EasyPost.Parameters;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

            var client = new EasyPost.Client(apiKey);

            Parameters.ReferralCustomer.RefundByAmount parameters = new()
            {
                Amount = 2000,
            };

            PaymentRefund refund = await client.Beta.ReferralCustomer.RefundByAmount(parameters);

            Console.WriteLine(JsonConvert.SerializeObject(refund, Formatting.Indented));
        }
    }
}
