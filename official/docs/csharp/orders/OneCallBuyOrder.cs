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
    public async Task OneCallBuyOrder()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        Order order = await Order.Create(new Dictionary<string, object>()
        {
            {
                "carrier_accounts", new List<string>()
                {
                    "ca_..."
                }
            },
            {
                "service", "NextDayAir"
            },
            {
                "to_address", new Dictionary<string, string>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "from_address", new Dictionary<string, string>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "shipments", new List<Dictionary<string, object>>()
                {
                    {
                        new Dictionary<string, object>
                        {
                            {
                                "parcel", new Dictionary<string, object>()
                                {
                                    {
                                        "weight", 10.2
                                    }
                                }
                            }
                        }
                    },
                    {
                        new Dictionary<string, object>
                        {
                            {
                                "parcel", new Dictionary<string, object>()
                                {
                                    {
                                        "predefined_package", "FedExBox"
                                    },
                                    {
                                        "weight", 17.5
                                    }
                                }
                            }
                        }
                    }
                }
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
    }
}
