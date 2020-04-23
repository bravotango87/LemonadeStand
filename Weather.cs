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

        public Random random;
        public int[] WeatherTemp = new int [] { 50, 60, 70, 90, 100 };
        public string[] WeatherConditions = new string[] { "hot", "sunny", " overcast", "", "rainy", "foggy" };
        public string condition;
        private List<string> conditions;
        

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

            //int randomNumber= random.Next(conditions.Count);
            //condition = conditions[4];
            


            

        }

        public void GenerateTemparture()
        {
            // set the temperature variable eqaul to a random number between 40 and 100

            int randonNumber = random.Next(40, 100);
            Console.WriteLine(random.Next(40, 100));





        }
        public void DisplayWeather()
        {

        }
        
       

        
        

        
        



    }




}
