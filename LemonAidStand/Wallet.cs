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
        double cash;


        // Contstructor ( SPAWNER )
        public Wallet()
        {
           // double cash = 20;
        }

        // Methods ( CAN DO )

        public void DebitWallet(double grocerybill)
        {

            cash = cash - grocerybill;

        }


    }
}
