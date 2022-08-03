using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallOfDuty2
{
    public class CallOfDutyGenerator
    {
        private HttpClient _client;

        public CallOfDutyGenerator(HttpClient client)
        {
            _client = client;
        }

        public static RestResponse CallOfDuty()
        {

            string key = File.ReadAllText("appsettings.json");
            string ApiKey = JObject.Parse(key).GetValue("APIKEY").ToString();
            string ApiHost = JObject.Parse(key).GetValue("APIHOST").ToString();



            Console.Write("Please enter Gamer tag for Call Of Duty Warzone:");
            string gamertag = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Please enter the platform you are playing on:");
            string platform = Console.ReadLine();


            var client = new RestSharp.RestClient($"https://call-of-duty-modern-warfare.p.rapidapi.com/warzone/{gamertag}/{platform}");
            var request = new RestRequest();
            request.AddHeader("X-RapidAPI-Key", $"{ApiKey}");
            request.AddHeader("X-RapidAPI-Host", $"{ApiHost}");
            var response = client.Execute(request);

            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("*****************************");

            Console.WriteLine($"{gamertag} stats :");

            return response;


        }



    }
}
