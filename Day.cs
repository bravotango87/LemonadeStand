using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
     // member variables (Has a)




     // constructor (Spawner)

        public Day()
        {

        }

     // member methods (Can do)
        
        public void DisplayDay()
        {
            int day = 0;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday !");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday !");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday !");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday !");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday !");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday !");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday !");
                    break;

            }
        }

    }   
}

        
    

    
