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
        public Dictionary<string, decimal> rates { get; set; }




        
      
        
    }
}
