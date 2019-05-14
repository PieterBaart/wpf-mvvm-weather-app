using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MWWMWeatherApp.Model;
using MWWMWeatherApp.View;

namespace MWWMWeatherApp.ViewModel.Commands {
    /// <summary>
    /// Handles the details button behaviour
    /// </summary>
    class DetailsCommand : ICommand {

        public WeatherVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public DailyForecast DetailDailyForecast { get; set; }

        public DetailsCommand(WeatherVM vm) {
            VM = vm;
        }

        /// <summary>
        /// Check wether it's possible to call the Execute() method
        /// </summary>
        /// <param name="parameter">Extra data for executing</param>
        /// <returns>Always true</returns>
        public bool CanExecute(object parameter) {
            return true;
        }

        /// <summary>
        /// Behaviour after clicking the details button
        /// </summary>
        /// <param name="parameter">Extra data for executing</param>
        public void Execute(object parameter) {
            if ((DailyForecast)parameter != null) {
                WeatherDetailsWindow detailsWindow = new WeatherDetailsWindow();
                detailsWindow.DataContext = (DailyForecast)parameter;
                detailsWindow.Show();
            }
        }
    }
}
