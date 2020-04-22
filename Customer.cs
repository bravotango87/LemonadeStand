using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        // member variables (Has a )

        List<string> names;
        public int temp;
        public int cupsToBuy;
        double demandProb;
        double temperatureProb;
        double conditionProb;
        public bool willBuy;
        double percent;




        // constructor (Spawner)

        public Customer()
        {
            names = new List<string>();

            names.Add("Customer 1");
            names.Add("Customer 2");
            names.Add("Customer 3");
            names.Add("Customer 4");
            names.Add("Customer 5");
            names.Add("Customer 6");
        }

         // if else statement so weather conditions & temp affect customers demand

        public void BuyLemonadeTemp(Weather weather)
        {
            if (weather.temperature <= 60)
            {
                temperatureProb = percent = 35;
            }
            else if (weather.temperature >= 75)
            {
                temperatureProb = percent = 80)
            }
        }



        //  if else statement on price of product (ex. price too high sales will decrease, price too low sales will increase)


        

        
        

        // member methods (CAN DO)
    }
}
