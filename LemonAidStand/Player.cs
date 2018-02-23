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
        Inventory inventory = new Inventory();
        Money money = new Money();
        Score score = new Score();
        ShoppingList shoppinglist = new ShoppingList();
        Stand stand = new Stand();

        // TodaysWeather

        // Contstructor ( SPAWNER )
        public Player()
        {
            
        }

        // Methods ( CAN DO )

    }
}
