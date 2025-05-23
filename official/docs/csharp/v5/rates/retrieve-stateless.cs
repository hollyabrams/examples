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
            var client = new EasyPost.Client("EASYPOST_API_KEY");

            EasyPost.Parameters.Beta.Rate.Retrieve shipmentDetails = new()
            {
                ToAddress = new EasyPost.Parameters.Address.Create
                {
                    Name = "Dr. Steve Brule",
                    Street1 = "179 N Harbor Dr",
                    City = "Redondo Beach",
                    State = "CA",
                    Zip = "90277",
                    Country = "US",
                    Phone = "8573875756",
                    Email = "dr_steve_brule@gmail.com"
                },
                FromAddress = new EasyPost.Parameters.Address.Create
                {
                    Name = "EasyPost",
                    Street1 = "417 Montgomery Street",
                    Street2 = "5th Floor",
                    City = "San Francisco",
                    State = "CA",
                    Zip = "94104",
                    Country = "US",
                    Phone = "4153334445",
                    Email = "support@easypost.com",
                },
                Parcel = new EasyPost.Parameters.Parcel.Create
                {
                    Length = 20.2,
                    Width = 10.9,
                    Height = 5,
                    Weight = 65.9
                }
            };

            List<EasyPost.Models.API.StatelessRate> rates = await client.Beta.Rate.RetrieveStatelessRates(shipmentDetails);

            Console.WriteLine(JsonConvert.SerializeObject(rates, Formatting.Indented));
        }
    }
}
