﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Store
    {
        // member variables ( HAS A )
        public Goods goods = new Goods();
       // public Checkout checkout = new Checkout();
        public Price price = new Price();

        // TodaysWeather

        // Contstructor ( SPAWNER )
        public Store()
        {
      

    }



        // Methods ( CAN DO )

        public double BuyLemons(double priceselected, int numberpurchased)
        {
            double costOfLemons = priceselected * numberpurchased;
            return costOfLemons;
            
            
        }

    }
}
