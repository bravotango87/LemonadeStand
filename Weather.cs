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

        List<string> weatherConditions;
       


        string condition;
        double temparature;

        // constructor (Spawner)

        public Weather()
       
        {


            weatherConditions = new List<string>();

            weatherConditions.Add("Bright and Sunny !");
            weatherConditions.Add("Overcast But Warm !");
            weatherConditions.Add("Chilly !");
            weatherConditions.Add("Coldddd !");
            weatherConditions.Add("Rain Rain Rain !");
          
                




        }


        public Weather(string condition, double temperature)
        {
            this.condition = condition;
            this.temparature = temperature;


        }



        // member methods (Can do)

        public void DisplayWeather()
        {
            double Weather = 99.1d;
            if (Weather < 70.5)
            {
                Console.WriteLine("Its Chilly Today !!!");

            }
            else
            {
                Console.WriteLine("Good Day For Some Lemonade !!!");
            }
        }
        
       

        // Display Weather
        

        
        



    }




}
