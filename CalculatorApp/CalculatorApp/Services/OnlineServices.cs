using CalculatorApp.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly:Dependency(typeof(OnlineServices))]
namespace CalculatorApp.Services
{
    public class OnlineServices : IOnlineServices
    {
        public async Task<string> Add(double number1, double number2)
        {
            var url = $"https://recipeappfunction.azurewebsites.net/api/add/{number1}/{number2}";
            var httpClient = new HttpClient();
            string message = await httpClient.GetStringAsync(url);
            return message;
        }
    }
}
