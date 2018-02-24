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

            // set up the game
                // substances a player --> player substances the inventory
                //substances 


            //set up the game
            ui.Instructions();
            ui.DisplayPlayerInventory();
            string todaysWeather = day.weather.CreateWeather(CreateRandomNumber(6));
            ui.DisplayWeather(todaysWeather, "Today");
            string tomorrowsWeather = day.weather.CreateWeather(CreateRandomNumber(6));
            ui.DisplayWeather(tomorrowsWeather, "Tomorrow");



            // Player to buy Inventory from store


            // set up the initial game
            // double Money $10
            // int ICE 0
            // int Lemons 0
            // int sugar 0
            // int cups 0

            // set up the price structure

        }



    }
}
