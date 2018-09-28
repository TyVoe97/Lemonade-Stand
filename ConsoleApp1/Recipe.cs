using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Recipe
    {
        
        public double iceCubes;
        public double sugarCubes;
        public double lemons;
        public double paperCups;

        public Recipe()
        {

        }

        public void SetIceCubes()
        {
            Console.WriteLine("How many Ice Cubes do you want to buy?");
            iceCubes = double.Parse(Console.ReadLine());
            
        }
        public void SetLemons()
        {
            Console.WriteLine("How many Lemons do you want to buy?");
            lemons = double.Parse(Console.ReadLine());
        }
        public void SetPaperCups()
        {
            Console.WriteLine("How many Paper Cups do you want to buy?");
            paperCups = double.Parse(Console.ReadLine());
        }
        public void SetSugarCubes()
        {
            Console.WriteLine("How many Sugar Cubes do you want to buy?");
            sugarCubes = double.Parse(Console.ReadLine());
        }
    }
}
