using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LemonadeStandGame
{

    public class Weather
    {
        // member variables (Has)

        Random random;
        int temperatureHigh;
        int temperatureLow;
        public int temperature;
        public string condition;
        private List<string> conditions;
        

        // constructor (Spawner)

        public Weather()
        {
            Random random = new Random();
            temperatureHigh = 100;
            temperatureLow = 40;
            

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
            // set condition variable to a random value the in the list of condtions
            //generate a random number between 0 and 4 and use that random number as the index number in the line below

            int randomNumber= random.Next(conditions.Count);
            condition = conditions[randomNumber];
            


            condition = conditions[4];

        }

        public void GenerateTemparture()
        {
            // set the temperature variable eqaul to a random number between 40 and 100

            int temp = random.Next(40, 100);
            Console.WriteLine(random.Next(40, 100));





        }
        public void DisplayWeather()
        {

        }
        
       

        
        

        
        



    }




}
