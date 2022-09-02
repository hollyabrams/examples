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
    public async Task RetrieveParcel()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Parcel parcel = await Parcel.Retrieve("prcl_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(parcel, Formatting.Indented));
    }
}
