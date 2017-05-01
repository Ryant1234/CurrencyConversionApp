using ExchangeRateApp.Models;
using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRateApp.Services
{
   public  class ExchangeRateService
    {

        List<String> countryNames = new List<string>();
     

        private const string Url = "http://api.fixer.io/latest?base=";

        // NativeMessageHandler because of  HttpClient throwing exceptions..

        private HttpClient _client = new HttpClient(new NativeMessageHandler());


        public async Task <ExchangeRate> GetExchangeRates(string exchangeFrom, string exchangeTo)
        {

           var currencyFrom = countriesDictionary[exchangeFrom];
            var currencyTo = countriesDictionary[exchangeTo];

            if (currencyFrom == currencyTo)
                return null;


             

            // Gets a single movie for the detail page
            var response = await _client.GetAsync($"{Url}{currencyFrom}");

            // If response statuscode is equal to StatusCode NotFound
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            return   JsonConvert.DeserializeObject<ExchangeRate>(content);

           

        }





        public decimal CaculateExchangeRate(int exchangeFromAmount, decimal exchangeToRate)

        {
                return exchangeFromAmount * exchangeToRate; ;
        }





     
    


    public Dictionary<string, string> countriesDictionary = new Dictionary<string, string>
    {
        {"Australian Dollar", "AUD"  },
        {"Canadian Dollar",  "CAD" },
        {"Swiss Franc",  "CHF" },
        {"Czech Koruna", "CZK"  },
        {"Danish Krone",  "DKK"  },
        
        {"Pound Sterling", "GBP"  },
        {"Hong Kong Dollar",  "HKD"  },
        {"Hungarian Forint", "HUF"  },
        {"Iceland Krona", "ISK"  },
        {"Japanese Yen",  "JPY"  },
        {"Korean Won", "KRW"  },
        {"Lithuanian Litas", "LTL"  },
        {"Latvian Lats",  "LVL"  },
        { "Norwegian Krone" , "NOK" },
        { "New Zealand Dollar",  "NZD" },
        {"Polish Zloty",  "PLN"  },
        {"Swedish Krona" , "SEK" },
        { "Singapore Dollar", "SGD"  },
        { "US Dollar",  "USD" },
        { "South African Rand",  "ZAR" },

    };

        public List<string> countriesCurrencyList = new List<string>
        {
            "Australian Dollar",
            "Canadian Dollar",
            "Swiss Franc",
            "Czech Koruna",
            "Danish Krone",
            "Pound Sterling",
            "Hong Kong Dollar",
            "Hungarian Forint",
            "Iceland Krona",
            "Japanese Yen",
            "Korean Won",
            "Lithuanian Litas",
            "Latvian Lats",
            "Norwegian Krone" ,
            "New Zealand Dollar",
            "Polish Zloty",
            "Swedish Krona" ,
            "Singapore Dollar",
            "US Dollar",
            "South African Rand"
        };



    



    }


}