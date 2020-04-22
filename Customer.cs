﻿using System;
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

        List<Customer> customers;
        public int temp;
        public int cupsToBuy;
        double demandProb;
        double temperatureProb;
        double conditionProb;
        double cupPrice;
        public bool willBuy;
        public int shoppers;

        




        // constructor (Spawner)

        public Customer()
        {
            customers = new List<Customer>();
            shoppers = 50;
           


            
        }

         // if else statement so weather conditions & temp affect customers demand

        public void BuyLemonadeTemp(Weather weather)
        {
            if (weather.temperature <= 60)
            {
                temperatureProb = 35;
            }
            else if (weather.temperature >= 75)
            {
                temperatureProb = 80;
            }
        }

        public void BuyLemonadeCondition(Weather weather)
        {
            if (weather.condition == "Sunny")
            {
                conditionProb = 90;
            }
            else if (weather.condition == "Overcast But Warm")
            {
                conditionProb = 70;
            }
            else if (weather.condition == "Chilly")
            {
                conditionProb = 50;
            }
            else if (weather.condition == "Coldddd")
            {
                conditionProb = 20;
            }
            else if (weather.condition == "Rain Rain Rain")
            {
                conditionProb = 0;
            }
        }



        //  if else statement on price of product (ex. price too high sales will decrease, price too low sales will increase)

        public void WillBuyCup()
        {
            double cupPrice;
            bool willBuy = true;
            {
                if (willBuy == true)
                {
                    cupPrice = .75;
                }
                else if (willBuy == true)
                {
                    cupPrice = .95;
                }
                else if (willBuy == true)
                {
                    cupPrice = 1.00;
                }
                else if (willBuy == false)
                {
                    cupPrice = 1.50;
                }

            }
        }







        // member methods (CAN DO)

        // generate customers (50)

        public void GenerateCustomers()
        {
            for (int i = 0; i < shoppers; i++)
            {
                customers.Add(new Customer());
            }
        }


    }
}
