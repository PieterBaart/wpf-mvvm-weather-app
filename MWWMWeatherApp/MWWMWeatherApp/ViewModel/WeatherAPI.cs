using Newtonsoft.Json;
using MWWMWeatherApp.Model;
using System.Net.Http;
using System.Threading.Tasks;

namespace MWWMWeatherApp.ViewModel {
    /// <summary>
    /// 
    /// Use this class for requests to AccuWeather API
    /// 
    /// </summary>
    class WeatherAPI {
        /// <summary>
        /// Unique key used for requesting AccuWeather
        /// </summary>
        public const string API_KEY = "hu50TD6i9xOTUwdgEGyTpDJLjhjqT1AF";

        /// <summary>
        /// Base Url for making requests to AccuWeather forecast
        /// {0} - location key
        /// {1} - api key
        /// </summary>
        public const string BASE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&metric=true";

        /// <summary>
        /// Get the weather forecast
        /// </summary>
        /// <param name="locationKey">unique key of the location to check the weather forecast for</param>
        /// <returns></returns>
        public static async Task<Forecast> GetWeatherInformationAsync(string locationKey) {
            Forecast result = new Forecast();

            string url = string.Format(BASE_URL, locationKey, API_KEY);

            using (HttpClient client = new HttpClient()) {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Forecast>(json);
            }
            return result;
        }
    }
}
}
