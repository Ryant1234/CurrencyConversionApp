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
        private const string Url = "http://api.fixer.io/latest?base=";

        // NativeMessageHandler because of  HttpClient throwing exceptions..

        private HttpClient _client = new HttpClient(new NativeMessageHandler());

        public async Task<ExchangeRate> GetExchangeRate(string exchangeFrom)
        {
            // Gets a single movie for the detail page
            var response = await _client.GetAsync($"{Url}");

            // If response statuscode is equal to StatusCode NotFound
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ExchangeRate>(content);
        }
    }
}

