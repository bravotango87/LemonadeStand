using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        // member variables (Has a )

        int amountOfLemons;
        int amountOfSugarCubes;
        int amountOfIceCubes;
        double pricePerCup;
        List<string> recipe;


        // constructor (Spawner)

        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0.75;

            recipe = new List<string>();

            recipe.Add("Lemons");
            recipe.Add("Sugar Cubes");
            recipe.Add("Ice Cubes");
            
            
        }

       // member methods (Can do)
    }
}
