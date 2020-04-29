using RestSharp;
using System;
using System.IO;

namespace CurrencyConverterAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(@"C:\Users\Devrim\Documents\GitHub\.NetProjects\HardProjects\CurrencyConverterAPI\CurrencyConverterAPI\token.txt");
            var client = new RestClient("https://currency-converter5.p.rapidapi.com/currency/convert?&amp;from=usd&amp;to=try&amp;amount=10&amp;format=json");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", contents);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response);
        }
    }
}
