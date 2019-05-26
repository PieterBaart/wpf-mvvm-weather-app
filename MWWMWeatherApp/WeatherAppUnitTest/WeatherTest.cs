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

            //assety
            int actualQueryLength = weatherVM.Query.Length;
            Assert.AreEqual(actualQueryLength, expectedQueryLength, "Query not cuting strings correctly");
        }
    }
}
