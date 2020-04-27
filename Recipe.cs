using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Recipe      // only make recipe in this class (single responsibilty principal)
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
            amountOfLemons = 2;
            amountOfSugarCubes = 3;
            amountOfIceCubes = 4;
            pricePerCup = 0.75;

            recipe = new List<string>();

            recipe.Add("Lemons");
            recipe.Add("Sugar Cubes");
            recipe.Add("Ice Cubes");
            
            
        }

       // member methods (Can do)
    }
}
