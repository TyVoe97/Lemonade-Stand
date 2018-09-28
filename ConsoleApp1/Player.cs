using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Player
    {
        string player1;
        Recipe recipe;
        Inventory inventory;

        public Player()
        {

        }
        public void PrintName()
        {
            Console.WriteLine("What's your name");
            string player1 = Console.ReadLine();
            Console.WriteLine("Hello " + player1);

        }
        public void SetIceCubes()
        {
            
            recipe.SetIceCubes();
            recipe.SetLemons();
            recipe.SetPaperCups();
            recipe.SetSugarCubes();
        }
    }
}
