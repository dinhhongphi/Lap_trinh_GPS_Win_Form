using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GPS_App
{
    public class Map
    {
        private const string URL_GET_MAP_INFO_FROM_IP = "http://freegeoip.net/json/";
        private const string URL_MAP_SEARCH = "http://maps.google.com/maps";
        private const string URL_MAP_API = "https://maps.googleapis.com/maps/api/geocode/json";
        public static MapInfo_Ip GetMapInfoByIP(string ip)
        {
            HttpClient res = new HttpClient();
            var task = res.GetAsync(URL_GET_MAP_INFO_FROM_IP + ip);
            task.Wait();
            if (task.IsCompleted)
            {
                var result = task.Result;
                var task2 = result.Content.ReadAsStringAsync();
                task2.Wait();
                if (task2.IsCompleted)
                {
                    string rs = task2.Result;
                    MapInfo_Ip temp = JsonConvert.DeserializeObject<MapInfo_Ip>(rs);
                    return temp;
                }
            }
            return null; //error while get infomation
        }

        public static Uri SearchByAddress(string address)
        {
            return new Uri(URL_MAP_SEARCH + String.Format("?q={0}", HttpUtility.UrlEncode(address)));
        }

        public static Uri SearchByCoordinate(string lat, string lng)
        {
            return new Uri(URL_MAP_SEARCH + String.Format("?q={0}%2C{1}", lat,lng));
        }

        public static Location GetCoordinateFromAddress(string address)
        {
            HttpClient client = new HttpClient();
            var task = client.GetAsync(URL_MAP_API + String.Format("?address={0}&key={1}", HttpUtility.HtmlEncode(address), KeyMap.Key));
            task.Wait();
            if (task.IsCompleted)
            {
                var getContent = task.Result.Content.ReadAsStringAsync();
                getContent.Wait();
                if (getContent.IsCompleted)
                {
                    string content = getContent.Result;
                    MapResult result = JsonConvert.DeserializeObject<MapResult>(content);
                    return result.results[0].geometry.location;
                }
            }
            return null;
        }

        public static string GetAddressFromCoordinate(Location location)
        {
            HttpClient client = new HttpClient();
            var task = client.GetAsync(URL_MAP_API + String.Format("?latlng={0},{1}&key={2}", location.lat,location.lng, KeyMap.Key));
            task.Wait();
            if (task.IsCompleted)
            {
                var getContent = task.Result.Content.ReadAsStringAsync();
                getContent.Wait();
                if (getContent.IsCompleted)
                {
                    string content = getContent.Result;
                    MapResult result = JsonConvert.DeserializeObject<MapResult>(content);
                    return result.results[0].formatted_address;
                }
            }
            return null;
        }
    }
}
