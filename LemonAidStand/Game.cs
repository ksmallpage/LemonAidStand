using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Game
    {
        // member variables

        // constructor

        // methods

       private void Instructions()
        {
           Console.WriteLine (" You have decided to open a lemonade stand to make some Money. You have complete control over your business.");
           Console.WriteLine (" There is a default lemonade recipe, depeding on the weather you can vary the recipe to try and sell more Lemonade." );
           Console.WriteLine (" You need to Buy enough ingredients to met customer demand. Demand will depend on the Weather");
           Console.WriteLine (" You can set the price during the day to see if this influences the number of cups sold.");
           Console.WriteLine (" The game will keep track of how much Money you have at the end - you start with $20 at the start.");
           Console.WriteLine(" TRY NOT TO LOOSE MONEY");
        }

       public void RunGame()
        {
            Instructions();

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
