using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        // member variables (Has a)


        List<string> days;

        Player player1;

        // constructor (Spawner)

        public Game()
        {
            player1 = new Player();

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

        public void RunGame()
        {
            DisplayDay();
            DisplayTemperature();
        }

        public int CurrentDay()
         
    }
}
