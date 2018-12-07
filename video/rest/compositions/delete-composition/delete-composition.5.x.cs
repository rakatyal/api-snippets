// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using Twilio;
using Twilio.Rest.Video.V1;
using static Twilio.Rest.Video.V1.CompositionResource;

class Program
{
    static void Main(string[] args)
    {
        // Find your API Key SID and Secret at twilio.com/console
        const string apiKeySid = "SKXXXX";
        const string apiKeySecret = "your_api_key_secret";

        TwilioClient.Init(apiKeySid, apiKeySecret);

        CompositionResource.Delete(
          pathSid: "CJXXXX"
        );

        Console.WriteLine("Composition removed");
    }
}
