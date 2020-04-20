using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{

    public class Weather
    {
        // member variables (Has)


        int temperatureHigh;
        int temperatureLow;
        public int temperature;
        public string condition;
        private List<string> conditions;
        Random random;

        // constructor (Spawner)

        public Weather()
        {
            temperatureHigh = 95;
            temperatureLow = 45;
            random = new Random();
            
            conditions = new List<string>();

            conditions.Add("Bright and Sunny !");
            conditions.Add("Overcast But Warm !");
            conditions.Add("Chilly !");
            conditions.Add("Coldddd !");
            conditions.Add("Rain Rain Rain !"); 
        }



        
         // member methods (Can do)
        public void GenerateCondition()
        {
            //set condition variable to a random value the in the list of condtions
        }

        public void GenerateTemparture()
        {
            //set the temperature variable eqaul to a random number between 40 and 100
        }
        public void DisplayWeather()
        {

        }
        
       

        
        

        
        



    }




}
