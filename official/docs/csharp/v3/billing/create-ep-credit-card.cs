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
            EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

            PaymentMethod paymentMethod = await Partner.AddCreditCardToUser("REFERRAL_USER_API_KEY", "0123456789101234", "01", "2025", "111", PaymentMethod.Priority.Primary);

            Console.WriteLine(JsonConvert.SerializeObject(paymentMethod, Formatting.Indented));
        }
    }
}
