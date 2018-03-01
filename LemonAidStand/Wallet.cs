using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    public class Wallet
    {
        // member variables ( HAS A )
        public double cash = 10.00;
        bool canbuy;


        // Contstructor ( SPAWNER )
        public Wallet()
        {

        }

        // Methods ( CAN DO )

        public double DebitWalletForLemonsPurchased(double cash, string lemonspurchased, List<double> lemonprice)
        {

            if (lemonspurchased == "10")
            {
                cash = cash - lemonprice.ElementAt(1);
            }
            else if (lemonspurchased == "30")
            {
                cash = cash - lemonprice.ElementAt(3);
            }
            else if (lemonspurchased == "75")
            {
                cash = cash - lemonprice.ElementAt(5);
            }
            return Math.Round(cash, 2);

        }

        public double DebitWalletForSugarPurchased(double cash,string sugarpurchased, List<double> sugarprice)
        {

            if (sugarpurchased == "8")
            {
                cash = cash - sugarprice.ElementAt(1);
            }
            else if (sugarpurchased == "20")
            {
                cash = cash - sugarprice.ElementAt(3);
            }
            else if (sugarpurchased == "48")
            {
                cash = cash - sugarprice.ElementAt(5);
            }
            return Math.Round(cash,2);

        }

        public double DebitWalletForIcePurchased(double cash, string icepurchased, List<double> iceprice)
        {

            if (icepurchased == "100")
            {
                cash = cash - iceprice.ElementAt(1);
            }
            else if (icepurchased == "250")
            {
                cash = cash - iceprice.ElementAt(3);
            }
            else if (icepurchased == "500")
            {
                cash = cash - iceprice.ElementAt(5);
            }
            return Math.Round(cash,2);

        }


        public double DebitWalletForCupsPurchased(double cash, string cupspurchased, List<double> cupprice)
        {

            if (cupspurchased == "25")
            {
                cash = cash - cupprice.ElementAt(1);
            }

            else if (cupspurchased == "50")
            {
                cash = cash - cupprice.ElementAt(3);
            }
            else if (cupspurchased == "100")
            {
                cash = cash - cupprice.ElementAt(5);
            }
            return Math.Round(cash, 2);

        }

        internal bool CanYouBuySugar(string numberOfCupsOfSugar, List<double> sugarprice)
        {
            if (numberOfCupsOfSugar == "8")
            {
                canbuy = cash >= sugarprice.ElementAt(1);
            }
            else if (numberOfCupsOfSugar == "20")
            {
                canbuy = cash >= sugarprice.ElementAt(3);
            }
            else if (numberOfCupsOfSugar == "48")
            {
                canbuy = cash >= sugarprice.ElementAt(5);
            }
            return canbuy;
        }

        internal bool CanYouBuyLemons(string numberOfLemons, List<double> lemonprice)
        
        {
            if (numberOfLemons == "10")
            {
                canbuy = cash >= lemonprice.ElementAt(1);
            }
            else if (numberOfLemons == "30")
            {
                canbuy = cash >= lemonprice.ElementAt(3);
            }
            else if( numberOfLemons == "75")
            {
                canbuy = cash >= lemonprice.ElementAt(5);
            }
            return canbuy; 
          
        }

        internal bool CanBuyCups(string numberOfPaperCups, List<double> cupprice)
        {
            if (numberOfPaperCups == "25")
            {
                canbuy = cash >= cupprice.ElementAt(1);
            }
            else if (numberOfPaperCups == "50")
            {
                canbuy = cash >= cupprice.ElementAt(3);
            }
            else if (numberOfPaperCups == "100")
            {
                canbuy = cash >= cupprice.ElementAt(5);
            }
            return canbuy;
        }

        internal bool CanYouBuyIceCubes(string numberOfIceCubes, List<double> icecubeprice)
        {
            if (numberOfIceCubes == "100")
            {
                canbuy = cash >= icecubeprice.ElementAt(1);
            }
            else if (numberOfIceCubes == "250")
            {
                canbuy = cash >= icecubeprice.ElementAt(3);
            }
            else if (numberOfIceCubes == "500")
            {
                canbuy = cash >= icecubeprice.ElementAt(5);
            }
            return canbuy;
        }

    }
}
