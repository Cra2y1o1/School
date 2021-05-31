using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;

namespace School.Controllers
{
    public class SmsController : Controller
    {
        public static string catchST;
        public IActionResult Index()
        {
            return View();
        }
        public static void sendSMS(string text, string phone)
        {
            try
            {
                var accountSid = "AC0ffce5254f2284576641513844c930ff";
                var authToken = "2f861eaa1787d085a837bd3abf0fb61c";
                TwilioClient.Init(accountSid, authToken);

                var from = new PhoneNumber("+19544177742");
                var to = new PhoneNumber(phone);

                var message = MessageResource.Create(
                    to: to,
                    from: from,
                    body: text);
                Console.WriteLine(message.Sid);
            }
            catch(Exception ex)
            {
                catchST = ex.Message;
            }
        }
    }
}
