using MWWMWeatherApp.Model;
using MWWMWeatherApp.ViewModel.Commands;
using System.Collections.ObjectModel;

namespace MWWMWeatherApp.ViewModel {
    /// <summary>
    /// The main ViewModel of the application.
    /// It is the closest one to the view.
    /// It's purpouse is to update the view via binding.
    /// </summary>
    class WeatherVM {

        private string query;
        private City selectedCity;

        /// <summary>
        /// The query written by the user in a TextBox
        /// </summary>
        public string Query {
            get { return query; }
            set {
                query = value;
                GetCities();
            }
        }

        // Observable collection is dynamic data collection 
        // that provides notifications when items get 
        // added, removed, or when the whole list is refreshed

        /// <summary>
        /// DailyForecasts for the city choosed by the user
        /// </summary>
        public ObservableCollection<DailyForecast> Forecasts { get; set; }

        /// <summary>
        /// Cities that need to show up when user
        /// types in a value for the query in the TextBox
        /// </summary>
        public ObservableCollection<City> Cities { get; set; }

        /// <summary>
        /// City selected by the user
        /// </summary>
        public City SelectedCity {
            get { return selectedCity; }
            set {
                selectedCity = value;
                GetWeather();
            }
        }

        /// <summary>
        /// Used for binding refresh button
        /// </summary>
        public RefreshCommand MRefreshCommand { get; set; }

        /// <summary>
        /// Used for binding details buttons
        /// </summary>
        public DetailsCommand MDetailsCommand { get; set; }

        public WeatherVM() {
            Forecasts = new ObservableCollection<DailyForecast>();
            Cities = new ObservableCollection<City>();
            SelectedCity = new City();
            MRefreshCommand = new RefreshCommand(this);
            MDetailsCommand = new DetailsCommand(this);
        }

        /// <summary>
        /// Change the data of the Cities ObservableCollection
        /// so that the view can bind
        /// </summary>
        private async void GetCities() {
            var cities = await WeatherAPI.GetAutocompleteAsync(Query);

            Cities.Clear();
            foreach (var city in cities) {
                Cities.Add(city);
            }
        }

        /// <summary>
        /// Change the data of the Forecasts ObservableCollection
        /// so that the view can bind
        /// </summary>
        public async void GetWeather() {
            string key = SelectedCity.Key;
            var weather = await WeatherAPI.GetWeatherInformationAsync(SelectedCity.Key);

            Forecasts.Clear();
            foreach (var forecast in weather.DailyForecasts) {
                Forecasts.Add(forecast);
            }
        }
    }
}
