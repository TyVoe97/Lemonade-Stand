using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Recipe
    {
        
        public string iceCubes;
        public string sugarCubes;
        public string lemons;
        public string paperCups;
       
        public Recipe()
        {
          

        }

        public void SetIceCubes()
        {
            
           
            Console.WriteLine("How many Ice Cubes do you want to buy?");
            int id = int.Parse(Console.ReadLine());
            if (id == 1) 
             Console.ReadLine();
            
        }
        public void SetLemons()
        {
            Console.WriteLine("How many Lemons do you want to buy?");
            lemons = (Console.ReadLine());
        }
        public void SetPaperCups()
        {
            Console.WriteLine("How many Paper Cups do you want to buy?");
            paperCups = (Console.ReadLine());
        }
        public void SetSugarCubes()
        {
            Console.WriteLine("How many Sugar Cubes do you want to buy?");
            sugarCubes = (Console.ReadLine());
        }
    }
}
