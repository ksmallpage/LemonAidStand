using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonAidStand;

namespace LemonaidTests.cs
{
    [TestClass]
    public class WeatherTests
    {
        [TestMethod]
        public void Weather_WithinRangeIndexZero_ReturnsOverCast()
        {
            Weather weather = new LemonAidStand.Weather();
            // arrange

            string expected = "Overcast";
            string actual;

            //act
            actual = weather.CreateWeather(0);
            //assert

            Assert.AreEqual(expected, actual);
        }
          [TestMethod]
        public void Weather_WithinRangeIndexFive_ReturnsMuggy()
        {
            Weather weather = new LemonAidStand.Weather();
            // arrange

            string expected = "Muggy";
            string actual;

            //act
            actual = weather.CreateWeather(5);
            //assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Weather_OutsideRangeIndex_Exception()
        {
            Weather weather = new LemonAidStand.Weather();
            // arrange

          //  string expected = "Muggy";
            string actual;

            //act
            actual = weather.CreateWeather(6);
            //assert

          //  Assert.AreEqual(expected, actual);

        }
    }
}
