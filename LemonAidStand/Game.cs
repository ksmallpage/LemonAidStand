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

        UI ui = new UI();
        Player player = new Player();
        Day day = new Day();
        Store store = new Store();

        



        // Contstructor ( SPAWNER )
        public Game()
        {

        }

        // Methods ( CAN DO )



       public void RunGame()
        {

            // set up the game
                // substances a player --> player substances the inventory
                //substances 

            ui.Instructions();
            ui.DisplayPlayerInventory();

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
