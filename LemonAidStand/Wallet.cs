using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Wallet
    {
        // member variables ( HAS A )
        public double cash = 20.0;


        // Contstructor ( SPAWNER )
        public Wallet()
        {

        }

        // Methods ( CAN DO )

        public double DebitWalletForLemonsPurchased(string lemonspurchased, List<double> lemonprice)
        {

            if (lemonspurchased == "100")
            {
                cash = cash - lemonprice.ElementAt(1);
            }
            else if (lemonspurchased == "30")
            {
                cash = cash - lemonprice.ElementAt(3);
            }
            else if(lemonspurchased == "75")
            {
                cash = cash - lemonprice.ElementAt(5);
            }
            return cash;


        }

    }
}
