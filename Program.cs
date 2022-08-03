using RestSharp;
using Newtonsoft.Json.Linq;
using CallOfDuty2;

bool cont = false;

do
{

    var response = CallOfDutyGenerator.CallOfDuty();

    var callofduty = JObject.Parse(response.Content);

    decimal KillDeathRatio = decimal.Parse(callofduty["br"]["kdRatio"].ToString());
    int wins = int.Parse(callofduty["br"]["wins"].ToString());
    int kills = int.Parse(callofduty["br"]["kills"].ToString());
    int downs = int.Parse(callofduty["br"]["downs"].ToString());
    int topTwentyFive = int.Parse(callofduty["br"]["topTwentyFive"].ToString());
    int objTime = int.Parse(callofduty["br"]["objTime"].ToString());
    int topTen = int.Parse(callofduty["br"]["topTen"].ToString());
    int contracts = int.Parse(callofduty["br"]["contracts"].ToString());
    int revives = int.Parse(callofduty["br"]["revives"].ToString());
    int topFive = int.Parse(callofduty["br"]["topFive"].ToString());
    int score = int.Parse(callofduty["br"]["score"].ToString());
    int timePlayed = int.Parse(callofduty["br"]["timePlayed"].ToString());
    int gamesPlayed = int.Parse(callofduty["br"]["gamesPlayed"].ToString());
    int tokens = int.Parse(callofduty["br"]["tokens"].ToString());
    decimal socrePerMinute = decimal.Parse(callofduty["br"]["scorePerMinute"].ToString());
    int cash = int.Parse(callofduty["br"]["cash"].ToString());
    int deaths = int.Parse(callofduty["br"]["deaths"].ToString());



    Console.WriteLine($"Wins: {wins}");

    Console.WriteLine($"Kills: {kills}");

    Console.WriteLine($"KD: {KillDeathRatio}");

    Console.WriteLine($"Downs: {downs}");

    Console.WriteLine($"TopTwentyFive: {topTwentyFive}");

    Console.WriteLine($"ObjectiveTime: {objTime}");

    Console.WriteLine($"TopTen: {topTen}");

    Console.WriteLine($"Contracts: {contracts}");

    Console.WriteLine($"Revives: {revives}");

    Console.WriteLine($"TopFive: {topFive}");

    Console.WriteLine($"Score: {score}");

    Console.WriteLine($"TimePlayed: {timePlayed}");

    Console.WriteLine($"GamesPlayed: {gamesPlayed}");

    Console.WriteLine($"Tokens: {tokens}");

    Console.WriteLine($"ScorePerMinute: {socrePerMinute}");

    Console.WriteLine($"Cash: {cash}");

    Console.WriteLine($"Deaths: {deaths}");
    Console.WriteLine("*****************************");

    bool iscorrect = true;
    do
    {
        Console.WriteLine();
        Console.WriteLine("*****************************");
        Console.Write("Would you like to try another gamertag/ Yes or NO?:");
        var userresponse = Console.ReadLine();
        if (userresponse.ToLower() == "yes")
        {
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("*****************************");
            cont = true;
            iscorrect = true;
        }
        else if (userresponse.ToLower() == "no")
        {
            cont = false;
            break;
        }
        else
        {
            Console.WriteLine("Sorry do not understand your response, please try again");
            iscorrect = false;
            Console.WriteLine();
            Console.WriteLine();

        }




    }while(iscorrect==false);


}while(cont==true);




