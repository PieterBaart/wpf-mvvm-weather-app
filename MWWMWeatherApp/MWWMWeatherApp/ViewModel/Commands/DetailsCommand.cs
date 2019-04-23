using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MWWMWeatherApp.View;

namespace MWWMWeatherApp.ViewModel.Commands {
    class DetailsCommand : ICommand {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            WeatherDetailsWindow detailsWindow = new WeatherDetailsWindow();
            detailsWindow.Show();
        }
    }
}
