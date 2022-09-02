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
    public async Task CreateShipment()
    {
        string apiKey = Environment.GetEnvironmentVariable("EASYPOST_API_KEY")!;

        EasyPost.ClientManager.SetCurrent(apiKey);

        // Create a shipment using all data in one API call

        Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
            { "parcel", new Dictionary<string, object>() {
                { "length", 20.2 },
                { "width", 10.9 },
                { "height", 5 },
                { "weight", 65.9 }
            } },
            { "from_address", new Dictionary<string, object>(){
                { "name", "EasyPost" },
                { "street1", "417 Montgomery Street" },
                { "street2", "5th Floor" },
                { "city", "San Francisco" },
                { "state", "CA" },
                { "zip", "94104" },
                { "country", "US" },
                {"phone", "4153334445"},
                {"email", "support@easypost.com"}
            } },
            { "to_address", new Dictionary<string, object>(){
                { "name", "Dr. Steve Brule" },
                { "street1", "179 N Harbor Dr" },
                { "city", "Redondo Beach" },
                { "state", "CA" },
                { "country", "US" },
                { "phone", "8573875756" },
                { "email", "dr_steve_brule@gmail.com" },
                { "zip", "90277" }
            } },
            { "customs_info", new Dictionary<string, object>(){
                {"id", "cstinfo_..." }
            } }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));

        // Create a shipment using ids of existing data

        Shipment shipmentWithIds = await Shipment.Create(new Dictionary<string, object>()
        {
            {
                "to_address", new Dictionary<string, object>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "from_address", new Dictionary<string, object>()
                {
                    {
                        "id", "adr_..."
                    }
                }
            },
            {
                "parcel", new Dictionary<string, object>()
                {
                    {
                        "id", "prcl_..."
                    }
                }
            },
            {
                "customs_info", new Dictionary<string, object>()
                {
                    {
                        "id", "cstinfo_..."
                    }
                }
            }
        });

        new TestOutputHelper().WriteLine(JsonConvert.SerializeObject(shipmentWithIds, Formatting.Indented));
    }
}
