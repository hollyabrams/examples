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

            bool success = await Billing.DeletePaymentMethod(PaymentMethod.Priority.Primary);

            Console.WriteLine(success.ToString());
        }
    }
}
