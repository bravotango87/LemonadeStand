using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        // member variables (Has a)


        List<string> days;
        int currentDay;
        public Player player;
        

        // constructor (Spawner)

        public Game()
        {

            player = new Customer();
            days = new List<string>();



            days.Add("Today is Monday !");
            days.Add("Today is Tuesday !");
            days.Add("Today is Wedneday !");
            days.Add("Today is Thursday !");
            days.Add("Today is Friday ! ");
            days.Add("Today is Saturday !");
            days.Add("Today is Sunday");

        }



        // member methods (Can do)

        

        
         
    }
}
