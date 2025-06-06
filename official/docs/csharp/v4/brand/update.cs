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

            EasyPost.Models.API.User user = await client.User.RetrieveMe();

            await user.UpdateBrand(new Dictionary<string, object>()
            {
                { "background_color", "#FFFFFF" },
                { "color", "#303F9F" },
                { "logo", "data:image/png;base64,iVBORw0K..." },
                { "logo_href", "https://easypost.com" },
                { "ad", null },
                { "ad_href", null },
                { "theme", "theme1" }
            });

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
