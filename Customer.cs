using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        // member variables (Has a )

        List<string> names;

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

         // if else statement so weather conditions & temp affect customers demand



        //  if else statement on price of product (ex. price too high sales will decrease, price too low sales will increase)


        }

        public override void SetName()
        {
            Console.WriteLine("Please Enter Your Name.");
            Console.ReadLine();
        }

        // member methods (CAN DO)
    }
}
