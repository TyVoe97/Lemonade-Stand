﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.ExecuteGame();

            Game rules = new Game();
            game.SetRules();
        }
    }
}

