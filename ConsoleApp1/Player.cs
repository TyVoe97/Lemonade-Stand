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
         
        
        public Player(string player1)
        {
            this.player1 = player1;
        }
        public void PrintName()
        {

            Console.WriteLine("Your name is {0}" + this.player1);
        }
        
    }
}
