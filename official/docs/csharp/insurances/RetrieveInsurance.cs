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
    public async Task RetrieveInsurance()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Insurance insurance = await Insurance.Retrieve("ins_...");

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(insurance, Formatting.Indented));
    }
}
