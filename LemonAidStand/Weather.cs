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


        // constructor
        public Weather()
        {
           
            weathertypes = new List<string>() { "Overcast", "Cloudy", "Rainy", "Sunny", "Hot", "Muggy" };
        }

        // methods

        public string CreateWeather(int randomNumber)
        {
            Console.WriteLine(weathertypes[randomNumber]);
            return weathertypes[randomNumber];
        }


    }
}
