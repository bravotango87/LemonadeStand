using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        // member variables (Has a)
        
         
        List<Day> days;
        public Random random;
        public Weather weather;
        public Player player;
        public Store store;
        public int daysToPlay;
        
        public Day day;



        // constructor (Spawner)

        public Game()
        {

            random = new Random();
            weather = new Weather();
            player = new Player();
            store = new Store();
            days = new List<Day>();
            daysToPlay = 7;
            day = new Day();
            
        }


        public void RunGame()
        {
            Random random = new Random();
            Console.WriteLine("This game is for 7 days, so plan accordingly !");
            Console.Clear();
            player = new Player();
            Console.WriteLine("Good Morning !");
            DisplayForecast();
            MainMenu();
            GameOver(player);



        }


        //Create a method that is called GenerateDays
        //using a for loop add seven day objects to the days list

        // member methods (Can do)

        public void GenerateDays()
        {
            for(int i= 0; i < daysToPlay; i++)
            {
                days.Add(new Day());
                
            }
        }

       

            //day.weather.GetWeather();
            //Forecast method
            //DisplayForecast,loop over every day and print out days weather temp and condition to the console.
        public void DisplayForecast()
        {
            
            {
                
            }
           
            
                
    
          
            

        }




        public void GameOver(Player player)
        {
            Console.WriteLine("The game is over ! Here is a summary of how you did:");
        }
        public void MainMenu()
    {
        Console.WriteLine("Welcome to the Lemonade Stand");
        Console.WriteLine("Please choose an option from the menu");
        
        Console.WriteLine("Enter 1 to check inventory");
        Console.WriteLine("Enter 2 to check wallet");
        Console.WriteLine("Enter 3 to make recipe");
        Console.WriteLine("Enter 4 to check recipe");
        Console.WriteLine("Enter 5 to go to stand");


        string userInput = Console.ReadLine();

        switch (userInput)
        {
            
            case "1":
                Console.Clear();
                Console.WriteLine("You currently have "); // amount of lemons,sugar,ice cubes,cups
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("You have "); // amount of money in wallet
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Enter amount of lemons, sugar, icecubes and cuops you would like to use"); // enter item amount
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Your lemonade contains "); // receipe 
                break;
            case "5":
                Console.WriteLine("Time to sell some lemonade !");
                break;


        }


       


    }





        

        
         
    }
}
