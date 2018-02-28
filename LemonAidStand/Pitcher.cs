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
        List<int> standardPitcher = new List<int>();

        // TodaysWeather

        // Contstructor ( SPAWNER )
        public Pitcher()
        {
            List<int> standardPitcher = new List<int>() { 4, 4, 8 }; // lemons , Cups of Sugars , Cups per Pitcher
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
    }
}
