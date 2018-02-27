using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Customer
    {
        // member variables
        int customersGeneratedByWeather;
        int customersGeneratedByTemperature;
        int dailyPotentialCustomers;
        List<int> dailyCustomers = new List<int>();

        // constructor
        public Customer()
        {

        }

        public int HowManyCustomersByWeather(string todaysWeather, List<int> weatherConstants)
        {
            if (todaysWeather == "Overcast")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(0);
            }
            else if (todaysWeather == "Cloudy")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(1);
            }
            else if (todaysWeather == "Rainy")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(2);
            }
            else if (todaysWeather == "Sunny")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(3);
            }
            else if (todaysWeather == "Clear")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(4);
            }
            else if (todaysWeather == "Muggy")
            {
                customersGeneratedByWeather = weatherConstants.ElementAt(5);
            }
            return customersGeneratedByWeather;

        }

        public int HowManyCustomersByTemperature(int todaysTemperature, List<int> temperatureConstants)
        {
            if (todaysTemperature == 95)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(5);
            }
            else if (todaysTemperature == 90)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(4);
            }
            else if (todaysTemperature == 85)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(3);
            }
            else if (todaysTemperature == 75)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(2);
            }
            else if (todaysTemperature == 65)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(1);
            }
            else if (todaysTemperature == 55)
            {
                customersGeneratedByTemperature = temperatureConstants.ElementAt(0);
            }
            return customersGeneratedByTemperature;

        }

        public int HowManyPotentialDailyCustomers(int customersGeneratedByWeather, int customersGeneratedByTemperature)
        {
            dailyPotentialCustomers = customersGeneratedByTemperature + customersGeneratedByWeather;
            return dailyPotentialCustomers;
        }

        public void CreateDailyCustomerList()
        {
            for(int i = 1; i <= dailyPotentialCustomers; i++)
            {
                dailyCustomers.Add(i);
            }
        }

    }
}
