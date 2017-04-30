using ExchangeRateApp.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExchangeRateApp.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExchangeRatePage : ContentPage
    {
        private ExchangeRateService _exchangeRateService = new ExchangeRateService();

        public ExchangeRatePage()
        {
            InitializeComponent();
            pickerConvertFrom.ItemsSource = _exchangeRateService.countriesCurrencyList;
            pickerConvertTo.ItemsSource = _exchangeRateService.countriesCurrencyList;
            pickerConvertTo.SelectedIndex = 1;

        }

        async void pickerConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var currencyFrom = pickerConvertFrom.Items[pickerConvertFrom.SelectedIndex];
            var currencyTo = pickerConvertTo.Items[pickerConvertTo.SelectedIndex];
            var exchangeAmount = int.Parse(txtCurrencyAmount.Text);


        
                var exchangeRates = await _exchangeRateService.GetExchangeRates(currencyFrom, currencyTo);


            var exchangeTo = _exchangeRateService.countriesDictionary[currencyTo];

            var rate = exchangeRates.rates[exchangeTo];

            var amount =  _exchangeRateService.CaculateExchangeRate(exchangeAmount, rate).ToString();

            var message = $"{exchangeAmount} {currencyFrom} = $ {amount} {exchangeTo} ";

             lblexchangedAmount.Text = amount.ToString();
               
            }
      
         


        


        }




          



    
    }
