using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Pitcher
    {
        // member variables ( HAS A )
        public List<int> standardPitcher = new List<int>() { 4, 4, 8 }; // lemons , Cups of Sugars , Cups per Pitcher

     

        // Contstructor ( SPAWNER )
        public Pitcher()
        {
           
        }

        // Methods ( CAN DO )

        public List<int> CreatePitcher(string pitcherChoice)
        {
            if (pitcherChoice == "Standard")
            {
                return standardPitcher;
            }
            else
            {
                return null;
            }
        }

        public int CalculateHowManyPitchers(List<int> pitcherRecipe, List<int> currentInventory) // lemons, sugar
        {
            int numberOfPitchers;
            int numberOfLemons = currentInventory.ElementAt(0);
            int cupsOfSugar = currentInventory.ElementAt(1);
            int numberOfPitchersLemonsCanMake = numberOfLemons / pitcherRecipe.ElementAt(0);
            int numberOfPitchersSugarCanMake = cupsOfSugar / pitcherRecipe.ElementAt(1);

            if(numberOfPitchersLemonsCanMake < numberOfPitchersSugarCanMake)
            {
                return numberOfPitchers = numberOfPitchersLemonsCanMake;
            }
            else
            {
                return numberOfPitchers = numberOfPitchersSugarCanMake;
            }
            




        }

        internal int CalculatePitchersToMake(int howManyCupsCanBeSold, List<int> pitcherRecipe)
        {
            int pitchersMade = howManyCupsCanBeSold / pitcherRecipe.ElementAt(2);
            return pitchersMade;
        }
    }
}
