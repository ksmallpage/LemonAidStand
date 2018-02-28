using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Game
    {
        // member variables ( HAS A )

        public UI ui = new UI();
        public Player player = new Player();
        public Day day = new Day();
        public Store store = new Store();
        private Random rnd = new Random();
        public int randomNumber;
        double cashforcups;
        double cashforlemons;
        double cashforsugar;
        double cashforice;





        // Contstructor ( SPAWNER )
        public Game()
        {
           // day.weather.CreateTodaysWeather(CreateRandomNumber(6));
        }

        // Methods ( CAN DO )

            public int CreateRandomNumber(int argrandomnumber)
        {
            
            randomNumber = rnd.Next(1, argrandomnumber);
            return randomNumber;
        }



        public void RunGame()
        {


            ui.Instructions();
            List<int> inventory = player.inventory.itemamounts;
            ui.DisplayCurrentInventory(inventory);
            GameSetup();
            Lemons();
            Sugar();
            Ice();
            Cups();
            ui.DisplayCurrentInventory(inventory);
            ui.DisplayCurrentCash(player.wallet.cash);
            string pitcherChoice = ui.GetTypeOfPitcherFromPlayer();
            List<int> pitcherList = player.stand.pitcher.CreatePitcher(pitcherChoice);
            string pricePerCup = ui.GetPriceOfCupFromPlayer();
            string icePerCup = ui.GetIceCubesPerCupFromPlayer();
            int buyingCustomers = day.customer.CreateHowManyDailyCustomersWillBuy();
          //  int howManyPitchers = player.stand.pitcher.CalculateHowManyPitchers(pitcherList, inventory);
            int howManyCupsCanBeSold = player.inventory.CalculateHowManyCupsSold(buyingCustomers, icePerCup);
            int howManyPitchesToMake = player.stand.pitcher.CalculatePitchersToMake(howManyCupsCanBeSold, pitcherList);
           

            







        }

        private void Cups()
        {
            string numberOfPaperCups = ui.UserInputForGroceryList(store.price.cupprice, "Paper Cups");
            bool canBuyCups = player.wallet.CanBuyCups(numberOfPaperCups, store.price.cupprice);
            if (canBuyCups == true)
            {
                player.inventory.UpdateInventory(numberOfPaperCups, "Paper Cups");
                cashforcups = player.wallet.DebitWalletForCupsPurchased(numberOfPaperCups, store.price.cupprice);
                ui.DisplayCurrentCash(cashforcups);
            }
            else
            {
                ui.DisplayCannotBuy();
                ui.DisplayCurrentCash(player.wallet.cash);
            }

        }

        private void Lemons()
        {
            string numberOfLemons = ui.UserInputForGroceryList(store.price.lemonprice, "Lemons");
            bool canyoubuyLemons = player.wallet.CanYouBuyLemons(numberOfLemons, store.price.lemonprice);
            if (canyoubuyLemons == true)
            {
                player.inventory.UpdateInventory(numberOfLemons, "Lemons");
                cashforlemons = player.wallet.DebitWalletForLemonsPurchased(numberOfLemons, store.price.lemonprice);
                ui.DisplayCurrentCash(cashforlemons);
            }
            else
            {
                ui.DisplayCannotBuy();
                ui.DisplayCurrentCash(player.wallet.cash);
            }
        }

        private void Sugar()
        {
            string numberOfCupsOfSugar = ui.UserInputForGroceryList(store.price.sugarprice, "Cups of Sugar");
            bool canYouBuySugar = player.wallet.CanYouBuySugar(numberOfCupsOfSugar, store.price.sugarprice);
            if (canYouBuySugar == true)
            {
                player.inventory.UpdateInventory(numberOfCupsOfSugar, "Cups of Sugar");
                cashforsugar = player.wallet.DebitWalletForSugarPurchased(numberOfCupsOfSugar, store.price.sugarprice);
                ui.DisplayCurrentCash(cashforsugar);
            }
            else
            {
                ui.DisplayCannotBuy();
                ui.DisplayCurrentCash(player.wallet.cash);
            }

        }

        private void Ice()
        {
            string numberOfIceCubes = ui.UserInputForGroceryList(store.price.icecubeprice, "Ice Cubes");
            bool canYouBuyIceCubes = player.wallet.CanYouBuyIceCubes(numberOfIceCubes, store.price.icecubeprice);
            if (canYouBuyIceCubes == true)
            {
                player.inventory.UpdateInventory(numberOfIceCubes, "Ice Cubs");
                cashforice = player.wallet.DebitWalletForIcePurchased(numberOfIceCubes, store.price.icecubeprice);
                ui.DisplayCurrentCash(cashforice);
            }
            else
            {
                ui.DisplayCannotBuy();
                ui.DisplayCurrentCash(player.wallet.cash);
            }

        }

        private void GameSetup()
        {

            string todaysWeather = day.weather.CreateWeather(CreateRandomNumber(6));
            ui.DisplayWeather(todaysWeather, "Today");
            string tomorrowsWeather = day.weather.CreateWeather(CreateRandomNumber(6));
            ui.DisplayWeather(tomorrowsWeather, "Tomorrow");
            int todaysTemperature = day.weather.SetTemperature(CreateRandomNumber(6));
            ui.DisplayTemperature(todaysTemperature);
            int customersGeneratedByWeather = day.customer.HowManyCustomersByWeather(todaysWeather, day.weather.potentialCustomerByWeather);
            int customersGeneratedByTemperature = day.customer.HowManyCustomersByTemperature(todaysTemperature, day.weather.potentialCustomersByTemperature);
            int howManyPotentialDailyCustomers = day.customer.HowManyPotentialDailyCustomers(customersGeneratedByWeather, customersGeneratedByTemperature);
            day.customer.CreateDailyCustomerList();
        }

        }
    }

