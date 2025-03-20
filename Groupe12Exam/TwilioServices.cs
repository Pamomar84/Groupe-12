using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Rest.Verify.V2.Service;
using Twilio.Exceptions;
using System.Configuration;
namespace Groupe12Exam
{
    internal class TwilioServices
    {
        public string accountSid = ConfigurationManager.AppSettings["Twilio:AccountSid"];
        public string authToken = ConfigurationManager.AppSettings["Twilio:AuthToken"];
        public string verifyServiceSid = ConfigurationManager.AppSettings["Twilio:VerifyServiceSid"];

        public TwilioServices()
        {
            // Initialiser la connexion à Twilio avec votre SID et AuthToken
            TwilioClient.Init(accountSid, authToken);
        }

        public void SendSms(string phoneNumber, string message)
        {
            var messageOptions = new CreateMessageOptions(
                new PhoneNumber(phoneNumber))
            {
                Body = message,
                From = new PhoneNumber("+19895821283")
            };
            var messageSent = MessageResource.Create(messageOptions);


        }
    }

}


