using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GPS_App
{
    public class MyIP
    {
        private const string URL_GET_IP = "https://api.ipify.org/?format=json";

        public static string Get()
        {
            HttpClient client = new HttpClient();
            var task = client.GetAsync(URL_GET_IP);
            task.Wait();
            if (task.IsCompleted)
            {
                var task2 = task.Result.Content.ReadAsStringAsync();
                task2.Wait();
                if (task2.IsCompleted)
                {
                    var result = task2.Result;
                    var define = new { ip = "" };
                    var myip = JsonConvert.DeserializeAnonymousType(result, define);
                    return myip.ip;
                }
            }
            return null;
        }
    }
}
