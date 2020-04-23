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
       // keep day class simple. only use weather and customer  variables. 

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

        public Day(List<Customer> customers)
        {
            this.customers = customers;
        }

        public Day(Random random)
        {
            this.random = random;
        }

        // member methods (Can do)

        public void DisplayDay()
        {
            

         }
        }

    }   


        
    

    
