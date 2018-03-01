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
        public List<int> itemamounts = new List<int>();
        int purchaseditems;
       


        // constructor
        public Inventory()
        {


            items = new List<string>() { "Lemons", "Sugar", "Ice", "Cups", "Pitcher" };
            itemamounts = new List<int>() { 0, 0, 0, 0, 1 };


        }

            // Methods ( CAN DO )

            public void UpdateInventory(string numberofitemspurchased, string item) // this should be create inventory
           {
            purchaseditems = int.Parse(numberofitemspurchased);
            if (item == "Lemons")
            {
                itemamounts[0] = itemamounts[0] + purchaseditems;
            }
            else if(item == "Cups of Sugar")
            {
                itemamounts[1] = itemamounts[1] + purchaseditems;
            }
            else if(item == "Ice Cubs")
            {
                itemamounts[2] = itemamounts[2] + purchaseditems;
            }
            else if(item == "Paper Cups")
            {
                itemamounts[3] = itemamounts[3] + purchaseditems;
            }

            }

        internal void DebitInventory()
        {
            throw new NotImplementedException();
        }

        public int CalculateHowManyCupsSold(int buyingCustomers, string icePerCup)
        {
            int iceInCups = int.Parse(icePerCup);
            int numberOfCubesNeeded = buyingCustomers * iceInCups;

            if (itemamounts.ElementAt(2) >= numberOfCubesNeeded && itemamounts.ElementAt(3) >= buyingCustomers)
            {
                return buyingCustomers;
            }
            else
            {
                if ((itemamounts.ElementAt(2) / iceInCups) < itemamounts.ElementAt(3)){
                    return buyingCustomers = (itemamounts.ElementAt(2) / iceInCups);
                }
                else
                {
                    return buyingCustomers = itemamounts.ElementAt(3);
                }
                
            }
        }   

    }
    }

