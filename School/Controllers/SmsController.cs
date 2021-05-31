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
                var accountSid = "AC0ffce5254f228457"+"6641513844c930ff";
                var authToken = "262bcdb9" + "4f15fc2358650a81d868dcb1";
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
