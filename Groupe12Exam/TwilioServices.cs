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
        //declarer ici les coordonnees pour se connecter au compte twilio 

        public TwilioServices()
        {
            // Initialiser la connexion à Twilio avec votre SID et AuthToken
            //TwilioClient.Init(accountSid, authToken);
        }

        public void SendSms(string phoneNumber, string message)
        {
            var messageOptions = new CreateMessageOptions(
                new PhoneNumber(phoneNumber))
            {
                Body = message,
                From = new PhoneNumber("Numero actif sur twilio")
            };
            var messageSent = MessageResource.Create(messageOptions);


        }
    }

}


