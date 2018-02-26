using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Inventory
    {
        // member variables ( HAS A )
        private List<string> items = new List<string>();
        private List<int> itemamounts = new List<int>();


        // constructor
        public Inventory()
        {


            items = new List<string>() { "Lemons", "Sugar", "Ice", "Cups", "Pitcher" };
            itemamounts = new List<int>() { 0, 0, 0, 0, 1 };


        }

            // Methods ( CAN DO )

            public void HowMuchInventory()
            {

            }

        }
    }

