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

        public int temperature;
        public Random random;
        public int[] WeatherTemp = new int [] { 50, 60, 70, 90, 100 };
        public string[] WeatherConditions = new string[] { "hot", "sunny", " overcast", "", "rainy", "foggy" };
        public string conditions;
        
        
        

        // constructor (Spawner)

        public Weather()
        {
            Random random = new Random();
            
           
        }




        // member methods (Can do)
        public void GenerateCondition()
        {
            // set condition variable to a random value the in the list of condtions
            //generate a random number between 0 and 4 and use that random number as the index number in the line below

            int WeatherCondition = random.Next(0, WeatherConditions.Length);
            conditions = WeatherConditions[WeatherCondition];
            
            


            

        }

        public void GenerateTemparture()
        {
            // set the temperature variable eqaul to a random number between 50 and 100

            int GenerateTemparture = random.Next(50, WeatherTemp.Length);
            temperature = WeatherTemp[GenerateTemparture];
        }

       
            






        
        public void DisplayWeather()
        {

        }
        
       

        
        

        
        



    }




}
