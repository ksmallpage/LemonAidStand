using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class UI
    {

        // member variables ( HAS A )

        // TodaysWeather

        // Contstructor ( SPAWNER )
        public UI()
        {

        }

        // Methods ( CAN DO )
     

        public void Instructions()
        {
            Console.WriteLine(" You have decided to open a lemonade stand to make some Money. You have complete control over your business.");
            Console.WriteLine(" There is a default lemonade recipe, depeding on the weather you can vary the recipe to try and sell more Lemonade.");
            Console.WriteLine(" You need to Buy enough ingredients to met customer demand. Demand will depend on the Weather");
            Console.WriteLine(" You can set the price during the day to see if this influences the number of cups sold.");
            Console.WriteLine(" The game will keep track of how much Money you have at the end - you start with $20 at the start.");
            Console.WriteLine(" TRY NOT TO LOOSE MONEY");
            Console.Clear();
        }
        public void DisplayWeather(string weather, string forcastday)
        {
            Console.WriteLine($"{forcastday} Weather is { weather}");
        }

        public void DisplayTemperature(int temperature)
        {
            Console.WriteLine($"The temperature today is {temperature} degrees.");
        }

        public string GetTypeOfPitcherFromPlayer()
        {
            string pitcherType;
            Console.WriteLine("What type of Pitcher will you make?");
            Console.WriteLine("'Standard' : 4 Lemons & 4 Cups of Sugar per Pitcher");
            return pitcherType = Console.ReadLine();

        }

        internal string GetIceCubesPerCupFromPlayer()
        {
            string iceCubesPerCup;
            Console.WriteLine("How many ice cubes are in each cup?");
            return iceCubesPerCup = Console.ReadLine();
        }

        public string GetPriceOfCupFromPlayer()
        {
            string pricePerCup;
            Console.WriteLine("What price in cents is each cup?");
            return pricePerCup = Console.ReadLine();
        }

        public void DisplayCurrentInventory(List<int> inventory)
        {
            Console.WriteLine("Your current Inventory:");
            Console.WriteLine($"You have {inventory.ElementAt(0)} Lemons");
            Console.WriteLine($"You have {inventory.ElementAt(1)} Cups of Sugar");
            Console.WriteLine($"You have {inventory.ElementAt(2)} Ice Cubs");
            Console.WriteLine($"You have {inventory.ElementAt(3)} Paper Cups");
            
        }

        public string UserInputForGroceryList(List<double> pricelist, string item)
        {
            string numberOfItem;
            Console.WriteLine("You can Buy:");
            Console.WriteLine($"{pricelist.ElementAt(0)} {item} for $ {pricelist.ElementAt(1)}");
            Console.WriteLine($"{pricelist.ElementAt(2)} {item} for $ {pricelist.ElementAt(3)}");
            Console.WriteLine($"{pricelist.ElementAt(4)} {item} for $ {pricelist.ElementAt(5)}");
            Console.WriteLine($"How many {item} to you want to Buy ");
            return numberOfItem = Console.ReadLine();
        
        }

        internal void DisplayCannotBuy()
        {
            Console.WriteLine("You do not have enough money for the item you want to buy");
        }

        public void DisplayCurrentCash(double cash)
        {
            Console.WriteLine($"Your current cash is {cash}");
        }
    }
}



