﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        // member variables (Has a)
        
         
        List<string> days;
        public Random random;
        public Weather weather;
        public Player player;
        public Store store;
        public Day day;
        public int randomValue;



        // constructor (Spawner)

        public Game()
        {

            random = new Random();
            weather = new Weather();
            player = new Player();
            store = new Store();
            day = new Day(random);
        }
        public void RunGame()
        {
           

        }




          

        }



        // member methods (Can do)

        public void TodayWeather()
        {
            day.weather.GetWeather();
        }
        
        public void MainMenu()
    {
        Console.WriteLine("Welcome to the Lemonade Stand");
        Console.WriteLine("Please choose an option from the menu");
        Console.WriteLine("Enter 1  to check weather");
        Console.WriteLine("Enter 2 to check inventory");
        Console.WriteLine("Enter 3 to check wallet");
        Console.WriteLine("Enter 4 to make recipe");
        Console.WriteLine("Enter 5 to check recipe");
        Console.WriteLine("Enter 6 to go to stand");


        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("Todays weather is "); // current day's weather (random number)
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("You currently have "); // amount of lemons,sugar,ice cubes,cups
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("You have "); // amount of money in wallet
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Enter amount of lemons, sugar, icecubes and cuops you would like to use"); // enter item amount
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("Your lemonade contains "); // receipe 
                break;
            case "6":
                Console.WriteLine("Time to sell some lemonade !");
                break;


        }
        
        

    }





        

        
         
    }
}
