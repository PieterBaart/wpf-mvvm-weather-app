using System;
using System.Collections.Generic;
using System.ComponentModel;

/// <summary>
/// 
/// The AccuWeatherForecast.cs file is the model for the weather forecast.
/// It's main functionality is to provide a class which objects can be representing json file in the app.
/// This class is Forecast.cs and it provides a public IList of DailyForecasts that can represent weather forecast for each day. 
/// 
/// INotifyPropertyChanged interface is used for knowing when a Property Value has changed.
/// That way we can generate events when the values are changed. So that the view and the model stay updated.
/// 
/// In all of the classes (except for the Forecast class), the setter for the properties calls the OnPropertyChanged() method,
/// which then calls the PropertyChanged event with an argument of propertyName
/// 
/// </summary>

namespace MWWMWeatherApp.Model {
    /// <summary>
    /// Represents minimum temperature in a day
    /// </summary>
    public class Minimum : INotifyPropertyChanged {
        private double _value;
        private string _unit;
        private int _unitType;

        /// <summary>
        /// Value of the temperature
        /// </summary>
        public double Value {
            get {
                return _value;
            }
            set {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        /// <summary>
        /// Type of the unit to represent the value
        /// </summary>
        public string Unit {
            get {
                return _unit;
            }
            set {
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }

        /// <summary>
        /// Value of the degrees in choosen unit
        /// </summary>
        public int UnitType {
            get {
                return _unitType;
            }
            set {
                _unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    /// <summary>
    /// Represents maximum temperature in a day
    /// </summary>
    public class Maximum : INotifyPropertyChanged {
        private double _value;
        private string _unit;
        private int _unitType;

        /// <summary>
        /// Value of the temperature
        /// </summary>
        public double Value {
            get {
                return _value;
            }
            set {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        /// <summary>
        /// Type of the unit to represent the value
        /// </summary>
        public string Unit {
            get {
                return _unit;
            }
            set {
                _unit = value;
                OnPropertyChanged("Unit");
            }
        }

        /// <summary>
        /// Value of the degrees in choosen unit
        /// </summary>
        public int UnitType {
            get {
                return _unitType;
            }
            set {
                _unitType = value;
                OnPropertyChanged("UnitType");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Represents minimum and maximum temperature in a day
    /// </summary>
    public class Temperature : INotifyPropertyChanged {
        private Minimum _minimum;
        private Maximum _maximum;

        /// <summary>
        /// Minimum temperature in a day
        /// </summary>
        public Minimum Minimum {
            get {
                return _minimum;
            }
            set {
                _minimum = value;
                OnPropertyChanged("Minimum");
            }
        }

        /// <summary>
        /// Maximum temperature in a day
        /// </summary>
        public Maximum Maximum {
            get {
                return _maximum;
            }
            set {
                _maximum = value;
                OnPropertyChanged("Maximum");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Represents an icon and a short description of the weather during the day
    /// </summary>
    public class Day : INotifyPropertyChanged {
        private int _icon;
        private string _iconPhrase;

        /// <summary>
        /// ID of an icon
        /// </summary>
        public int Icon {
            get {
                return _icon;
            }
            set {
                _icon = value;
                OnPropertyChanged("Icon");
            }
        }

        /// <summary>
        /// Short description of the weather
        /// </summary>
        public string IconPhrase {
            get {
                return _iconPhrase;
            }
            set {
                _iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Represents an icon and a short description of the weather during the night
    /// </summary>
    public class Night : INotifyPropertyChanged {
        private int _icon;
        private string _iconPhrase;

        /// <summary>
        /// ID of an icon
        /// </summary>
        public int Icon {
            get {
                return _icon;
            }
            set {
                _icon = value;
                OnPropertyChanged("Icon");
            }
        }

        /// <summary>
        /// Short description of the weather
        /// </summary>
        public string IconPhrase {
            get {
                return _iconPhrase;
            }
            set {
                _iconPhrase = value;
                OnPropertyChanged("IconPhrase");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Represents a full forecast for one day
    /// </summary>
    public class DailyForecast : INotifyPropertyChanged {
        private DateTime _date;
        private int _epochDate;
        private Temperature _temperature;
        private Day _day;
        private Night _night;
        private IList<string> _sources;
        private string _mobileLink;
        private string _link;

        /// <summary>
        /// Date of the forecast
        /// </summary>
        public DateTime Date {
            get {
                return _date;
            }
            set {
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Unix time of the forecast
        /// </summary>
        public int EpochDate {
            get {
                return _epochDate;
            }
            set {
                _epochDate = value;
                OnPropertyChanged("EpochDate");
            }
        }

        /// <summary>
        /// Minimum and maximum temperate in the day
        /// </summary>
        public Temperature Temperature {
            get {
                return _temperature;
            }
            set {
                _temperature = value;
                OnPropertyChanged("Temperature");
            }
        }

        /// <summary>
        /// Icon and a short description of the weather during the day
        /// </summary>
        public Day Day {
            get {
                return _day;
            }
            set {
                _day = value;
                OnPropertyChanged("Day");
            }
        }

        /// <summary>
        /// Icon and a short description of the weather during the night
        /// </summary>
        public Night Night {
            get {
                return _night;
            }
            set {
                _night = value;
                OnPropertyChanged("Night");
            }
        }

        /// <summary>
        /// Sources of the weather forecast
        /// </summary>
        public IList<string> Sources {
            get {
                return _sources;
            }
            set {
                _sources = value;
                OnPropertyChanged("Sources");
            }
        }

        /// <summary>
        /// Forecast url for mobile
        /// </summary>
        public string MobileLink {
            get {
                return _mobileLink;
            }
            set {
                _mobileLink = value;
                OnPropertyChanged("MobileLink");
            }
        }

        /// <summary>
        /// Forecast url
        /// </summary>
        public string Link {
            get {
                return _link;
            }
            set {
                _link = value;
                OnPropertyChanged("Link");
            }
        }

        /// <summary>
        /// Event called when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify that one of the properties has changed
        /// </summary>
        /// <param name="propertyName">Name of the property that has changed</param>
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// Represents a single forecast for 5 days
    /// </summary>
    public class Forecast {
        /// <summary>
        /// List of forecasts, one for each day
        /// </summary>
        public IList<DailyForecast> DailyForecasts { get; set; }

        /// <summary>
        /// Basic constructor, creates a new List of DailyForecast
        /// </summary>
        public Forecast() {
            DailyForecasts = new List<DailyForecast>();
        }
    }
}
