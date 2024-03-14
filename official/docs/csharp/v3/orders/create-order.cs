using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using EasyPost;

namespace EasyPostExamples
{
    public class Examples
    {
        public static async Task Main()
        {
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            Order order = await Order.Create(
                new Dictionary<string, object>()
                {
                    {
                        "to_address", new Dictionary<string, object>()
                        {
                            { "id", "adr_..." }
                        }
                    },
                    {
                        "from_address", new Dictionary<string, object>()
                        {
                            { "id", "adr_..." }
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
                                            { "weight", 10.2 }
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
                                            { "predefined_package", "FedExBox" },
                                            { "weight", 17.5 },
                                        }
                                    }
                                }
                            }
                        }
                    }
                });

            Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
        }
    }
}
