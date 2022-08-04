using RestSharp;
using Newtonsoft.Json.Linq;
using CallOfDuty2;

var client = new HttpClient();

var callofduty = new CallOfDutyGenerator(client);

callofduty.CallOfDuty();


