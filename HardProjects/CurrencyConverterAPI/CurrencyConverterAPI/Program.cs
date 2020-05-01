using Nancy.Responses;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Globalization;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CurrencyConverterAPI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please enter the currency you want compared to. Like AUD or USD.");
            string firstCurrency = Console.ReadLine();
            Console.WriteLine("Please enter the second currency!");
            string secondCurrency = Console.ReadLine();
            Console.WriteLine("Please enter the amount you want to convert");
            string user_Amount = Console.ReadLine();

            string contents = File.ReadAllText(@"C:\Users\Devrim\Documents\GitHub\.NetProjects\HardProjects\CurrencyConverterAPI\CurrencyConverterAPI\token.txt");
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var client = new RestClient("https://currency-converter5.p.rapidapi.com/");
            var request = new RestRequest($"currency/convert?format=json&from={firstCurrency}&to={secondCurrency}&amount={user_Amount}", Method.GET);
            request.AddHeader("x-rapidapi-host", "currency-converter5.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", contents);
            IRestResponse response = client.Execute(request);

            var json = response.Content;

            //JsonResponse convert = JsonConvert.DeserializeObject<JsonResponse>(json);

            Console.WriteLine(response.Content);


            JObject theJSON = JObject.Parse(response.Content);
            JToken amountToken = theJSON["amount"];
            if (amountToken == null || amountToken.Type == JTokenType.Null)
            {
                throw new JsonException("Amount was not defined.");
            }
            decimal amount = (decimal)amountToken;

            JToken ratesToken = theJSON["rates"];
            if (ratesToken == null || ratesToken.Type == JTokenType.Null)
            {
                throw new JsonException("Rates was not defined.");
            }



            JObject ratesObject = null;
            try
            {
                ratesObject = (JObject)ratesToken;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Rates is not a list.");
            }

            //JObject Notchildren = ratesToken.Children();
            foreach (var child in ratesObject.Children().Children())
            {
                JToken rateToken = child["rate"];
                if (rateToken == null || rateToken.Type == JTokenType.Null)
                {
                    throw new JsonException("Rate was not defined.");
                }
                Console.WriteLine(rateToken);
            }
            //var valuesJsonArray = JsonConvert.SerializeObject(ratesToken);


            Console.WriteLine(amount);
           // Console.WriteLine(valuesJsonArray);
            

            //Console.WriteLine(rates_Convert);


            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "Response.json")))
            //{
            //    Console.WriteLine(response.Content);
            //    outputFile.Write(response.Content);
            //}
        }
    }
}