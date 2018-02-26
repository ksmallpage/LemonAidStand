using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Weather
    {
        // member variables

        private List<string> weathertypes = new List<string>();
        private List<int> temperature = new List<int>();


        // constructor
        public Weather()
        {
           
            weathertypes = new List<string>() { "Overcast", "Cloudy", "Rainy", "Sunny", "Clear", "Muggy" };
            temperature = new List<int>() { 55, 65, 75, 85, 90, 95 };
        }

        // methods

        public string CreateWeather(int randomNumber)
        {
           // Console.WriteLine(weathertypes[randomNumber]);
            return weathertypes[randomNumber];

        }

        public int SetTemperature(int randomNumber)
        {
            return temperature[randomNumber];
        }



    }
}
