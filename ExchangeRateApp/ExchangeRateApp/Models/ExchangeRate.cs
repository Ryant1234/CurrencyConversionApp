using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRateApp.Models
{
   public class ExchangeRate
    {
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }




        public class Rates
        {
            public double AUD { get; set; }
            public double CAD { get; set; }
            public double CHF { get; set; }
            public double CYP { get; set; }
            public double CZK { get; set; }
            public double DKK { get; set; }
            public double EEK { get; set; }
            public double GBP { get; set; }
            public double HKD { get; set; }
            public double HUF { get; set; }
            public double ISK { get; set; }
            public double JPY { get; set; }
            public int KRW { get; set; }
            public double LTL { get; set; }
            public double LVL { get; set; }
            public double MTL { get; set; }
            public double NOK { get; set; }
            public double NZD { get; set; }
            public double PLN { get; set; }
            public int ROL { get; set; }
            public double SEK { get; set; }
            public double SGD { get; set; }
            public double SIT { get; set; }
            public double SKK { get; set; }
            public int TRL { get; set; }
            public double USD { get; set; }
            public double ZAR { get; set; }
        }

        
      
        
    }
}
