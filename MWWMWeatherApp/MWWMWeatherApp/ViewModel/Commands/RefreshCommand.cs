using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MWWMWeatherApp.ViewModel.Commands {
    /// <summary>
    /// Handles the refresh button behaviour
    /// </summary>
    class RefreshCommand : ICommand {
        public WeatherVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public RefreshCommand(WeatherVM vm) {
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
        /// Behaviour after clicking the refresh button
        /// </summary>
        /// <param name="parameter">Extra data for executing</param>
        public void Execute(object parameter) {
            VM.GetWeather();
        }
    }
}
