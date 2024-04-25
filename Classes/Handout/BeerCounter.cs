using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handout
{
    internal class BeerCounter
    {
        // define 2 static fields beerInStock and beersDrankCount
        public static int beerInStock = 0;
        public static int beersDrankCount = 0;

        // define 2 methods 
        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beerInStock -= bottlesCount;
        }
    }
}
