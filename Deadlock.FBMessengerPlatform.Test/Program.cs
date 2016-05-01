using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Test
{
    class Program
    {
        static Config _config = null;

        static void Main(string[] args)
        {
            _config = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "config.personal.json"));
            Test().Wait();
            Console.ReadLine();
        }

        static async Task Test()
        {
            //await Login();
            //await LoginWithToken();
            //await GetUserInformations();
            //await ListAccounts();
            //await ListPositions();
            //await GetPortfolios();
            //await ListOrders();
            //await NewOrder();
            //await CancelOrder();
            //await GetInstrument();
            //await GetQuote();
        }

        static async Task Login()
        {
            
        }
    }
}
