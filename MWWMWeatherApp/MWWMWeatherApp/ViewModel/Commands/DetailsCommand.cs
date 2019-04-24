using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MWWMWeatherApp.Model;
using MWWMWeatherApp.View;

namespace MWWMWeatherApp.ViewModel.Commands {
    class DetailsCommand : ICommand {
        public WeatherVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public DailyForecast DetailDailyForecast { get; set; }

        public DetailsCommand(WeatherVM vm) {
            VM = vm;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            WeatherDetailsWindow detailsWindow = new WeatherDetailsWindow();
            detailsWindow.DataContext = (DailyForecast)parameter;
            detailsWindow.Show();
        }
    }
}
