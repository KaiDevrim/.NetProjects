using RestSharp;
using RestSharp.Authenticators;
using System;
using System.IO;

namespace CurrencyConverterAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string contents = File.ReadAllText(@"C:\Users\Devrim\Documents\GitHub\.NetProjects\HardProjects\CurrencyConverterAPI\CurrencyConverterAPI\token.txt");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var client = new RestClient("https://currency-converter5.p.rapidapi.com/");
            var request = new RestRequest("currency/convert?format=json&from=AUD&to=CAD&amount=1", Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", contents);
            IRestResponse response = client.Execute(request);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "Response.json")))
            {
                Console.WriteLine(response.Content);
                outputFile.Write(response.Content);
            }
            

            
        }
    }
}
