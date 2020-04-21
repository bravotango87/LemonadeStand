using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame  
{    
    class Wallet
    {
        // member variables (Has a)


        private double amountOfMoney;
        
        public double AmountOfMoney
        {
            get
            {
                return amountOfMoney;
            }
           
        }

       // constructor (Spawner)
        

        public Wallet()
        {
            amountOfMoney = 20.00;
        }

       // member methods (Can do)

        public void PayMoneyForItems(double transactionAmount)
        {
            amountOfMoney -= transactionAmount;
        }
    }
}
