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
            var client = new EasyPost.Client(new EasyPost.ClientConfiguration("EASYPOST_API_KEY"));

            EasyPost.Parameters.User.UpdateBrand parameters = new()
            {
                BackgroundColorHexCode = "#FFFFFF",
                ColorHexCode = "#303F9F",
                LogoBase64 = "data:image/png;base64,iVBORw0K...",
                LogoUrl = "https://easypost.com",
                AdBase64 = null,
                AdUrl = null,
                Theme = "theme1"
            };

            EasyPost.Models.API.Brand brand = await client.User.UpdateBrand("user_...", parameters);

            Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
        }
    }
}
