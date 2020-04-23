using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        // member variables (Has a)

        public Weather weather;
        public Customer customer;
        List<Customer> customers;
        public Random random;



        // constructor (Spawner)

        public Day()
        {
            Random random = new Random();
            weather = new Weather();
            customer = new Customer();
        }

     // member methods (Can do)
        
        public void DisplayDay()
        {
            

         }
        }

    }   


        
    

    
