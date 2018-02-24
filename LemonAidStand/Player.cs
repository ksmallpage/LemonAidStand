using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Player
    {
        // member variables ( HAS A )
        public Inventory inventory = new Inventory();
        public Wallet money = new Wallet();
        public ShoppingList shoppinglist = new ShoppingList();
        public Stand stand = new Stand();

        // TodaysWeather

        // Contstructor ( SPAWNER )
        public Player()
        {
            
        }

        // Methods ( CAN DO )

        public void DisplayTest()
        {
            
        }

    }
}
