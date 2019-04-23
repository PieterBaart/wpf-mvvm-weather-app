using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MWWMWeatherApp.Model;

namespace MWWMWeatherApp.View {
    /// <summary>
    /// Interaction logic for WeatherForecastWindow.xaml
    /// </summary>
    public partial class WeatherForecastWindow : Window {
        public WeatherForecastWindow() {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var item = (ListView)sender;
            var forecast = (DailyForecast)item.SelectedItem;
            MessageBox.Show("U clicked" + forecast.Date.DayOfWeek);
        }
    }
}
