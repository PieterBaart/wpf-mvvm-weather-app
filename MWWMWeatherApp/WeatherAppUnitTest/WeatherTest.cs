using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWWMWeatherApp.ViewModel;

namespace WeatherAppUnitTest {
    [TestClass]
    public class WeatherTest {
        /// <summary>
        /// Tests if a query written by an user
        /// is cut to 10 characters
        /// </summary>
        [TestMethod]
        public void QueryLengthTest() {
            //arrange
            int expectedQueryLength = 10;
            string longquery = "abcdefghijkl";
            WeatherVM weatherVM = new WeatherVM();

            //act
            weatherVM.Query = longquery;

            //assert
            int actualQueryLength = weatherVM.Query.Length;
            Assert.AreEqual(actualQueryLength, expectedQueryLength, "Query not cuting strings correctly");
        }

        /// <summary>
        /// Tests wheter the application handles an empty query correctly
        /// </summary>
        [TestMethod]
        public void EmptyQueryTest() {
            //arrange
            int expectedForecastLength = 0;
            string query = "";
            WeatherVM weatherVM = new WeatherVM();

            //act
            weatherVM.Query = query;

            //assert
            int actualForecastLength = weatherVM.Forecasts.Count;
            Assert.AreEqual(actualForecastLength, expectedForecastLength, "Empty query not being handled correctly");
        }

        /// <summary>
        /// Checks if the list of forecasts is correctly cleared
        /// after erasing the query
        /// </summary>
        [TestMethod]
        public void ErasingQueryTest() {
            //arrange
            int expectedForecastLength = 0;
            string firstQuery = "r";
            string secondQuery = "";
            WeatherVM weatherVM = new WeatherVM();

            //act
            weatherVM.Query = firstQuery;
            weatherVM.Query = secondQuery;

            //assert
            int actualForecastLength = weatherVM.Forecasts.Count;
            Assert.AreEqual(actualForecastLength, expectedForecastLength, "Forecast list not erasing correctly");
        }
    }
}
