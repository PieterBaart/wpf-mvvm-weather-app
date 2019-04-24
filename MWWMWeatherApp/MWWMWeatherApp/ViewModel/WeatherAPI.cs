using Newtonsoft.Json;
using MWWMWeatherApp.Model;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MWWMWeatherApp.ViewModel {
    /// <summary>
    /// Use this class for requests to AccuWeather API
    /// </summary>
    class WeatherAPI {
        /// <summary>
        /// Unique key used for requesting AccuWeather
        /// </summary>
        public const string API_KEY = "i3aw74RzRj65wP6tHCcEW1jQYXYelyBA";

        /// <summary>
        /// Base Url for making requests to AccuWeather forecast
        /// {0} - location key
        /// {1} - api key
        /// </summary>
        public const string BASE_URL = "http://dataservice.accuweather.com/forecasts/v1/daily/5day/{0}?apikey={1}&metric=true";

        /// <summary>
        /// Base Url for making requests to AccuWeather autocmpletion
        /// {0} - location key
        /// {1} - api key 
        /// </summary>
        public const string BASE_URL_AUTOCOMPLETE = "http://dataservice.accuweather.com/locations/v1/cities/autocomplete?apikey={0}&q={1}";

        /// <summary>
        /// Get the weather forecast
        /// </summary>
        /// <param name="locationKey">unique key of the location to check the weather forecast for</param>
        /// <returns>Forecast object of the result forecast</returns>
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

        /// <summary>
        /// Get the autocompletion for the query 
        /// </summary>
        /// <param name="query">Currently written query</param>
        /// <returns>List of City objects that respond to the query</returns>
        public static async Task<List<City>> GetAutocompleteAsync(string query) {
            List<City> cities = new List<City>();

            string url = string.Format(BASE_URL_AUTOCOMPLETE, API_KEY, query);

            using (HttpClient client = new HttpClient()) {
                var response = await client.GetAsync(url);
                string json = await response.Content.ReadAsStringAsync();

                var city = JsonConvert.DeserializeObject<List<City>>(json);

                cities = city;
            }
            return cities;
        }
    }
}
