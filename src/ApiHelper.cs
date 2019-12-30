using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using System.Net.Http;

namespace CrytoWallet.src
{
    class ApiHelper
    {
        HttpClient httpC = new HttpClient();
        httpC.BaseAddress = new Uri("https://pro-api.coinmarketcap.com/v1/cryptocurrency/map");
        HttpResonseMessage response = client.GetAsync("").Result;
        var price = response.Content.ReadAsAsync<IEnumerable<Price>>().Result;
        label.Text = price;
    }
}
