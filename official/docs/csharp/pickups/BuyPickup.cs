using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples;

public class Examples
{
    [Fact]
    public async Task BuyPickup()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Pickup pickup = await Pickup.Retrieve("pickup_...");

        await pickup.Buy("UPS", "Same-Day Pickup");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(pickup, Formatting.Indented));
    }
}
