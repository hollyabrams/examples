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
    public async Task RetrieveTracker()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Tracker tracker = await Tracker.Retrieve("trk_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(tracker, Formatting.Indented));
    }
}
