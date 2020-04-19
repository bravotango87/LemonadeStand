using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{

    public class Weather
    {
        // member variables (Has)

        List<string> day;
        string condition;
        double temparature;

        // constructor (Spawner)

        public Weather()
        // per day of the week
        {
            int day = 0;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Monday!");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Today is Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("Today is Thursday!");
                    break;
                case 5:
                    Console.WriteLine("Today is Friday!");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday!");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday!");
                    break;


            }
                




        }


        public Weather(string condition, double temperature)
        {
            this.condition = condition;
            this.temparature = temperature;


        }



        // member methods (What it does)

        // Display Weather
        

        
        



    }




}
