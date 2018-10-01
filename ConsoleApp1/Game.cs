using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        public string Rules;
        Weather weather;
        Player player;
      

        
        public Game()
        {
            weather = new Weather();
            player = new Player();
           
        }
        public void ExecuteGame()
        {
            SetRules();
            PrintName();
            SetTemperature();
            SetForecast();
            SetIceCubes();
            Initialize();
            
            {
          
            }
            
            //display weather forecast
            // diplay player inventory
            // set recipe\ 
            //how much a cup of lemonade, ice cubes, sugar cubes, and paper cups. costs
            //
            // daily profit or loss needs to be displayed 
            //total of profit and loss of profit 
        }
        public void SetRules()
        {
            Console.WriteLine(" You have 7 days to sell as much lemonade as posible. The temperature, Weather, and Ingrediants will affect the way people buy lemonade. For example if it's sunny and 90 degress the customer will want more ice and taste to be sweeter or if its cold put less ice in so they will like it. Each day you will get to choose the price. If it's to high the customers wont buy it and if its to low customers will buy it but you wont earn any profit form it. Maybe you can raise the price on hot days and lower it on cold days so the customer will. ");
            Rules = (Console.ReadLine());
        } 
        
        public void SetTemperature()
        {

        }
        private void SetItem()
        {
            //paper cups 
            SetItem("1", "Paper Cups", 25, 1.10);
            SetItem("1", "Paper Cups", 75, 1.84);
            SetItem("1", "Paper Cups", 100, 3.22);
            // lemons
            SetItem("2", "Lemons", 10, 0.70);
            SetItem("2", "Lemons", 30, 2.75);
            SetItem("2", "Lemons", 75, 3.85);
            // Sugar Cubes
            SetItem("3", "Sugar Cubes", 8, 0.62);
            SetItem("3", "Sugar Cubes", 22, 1.75);
            SetItem("3", "Sugar Cubes", 50, 3.45);
            // IceCubes
            SetItem("4", "Ice Cubes", 100, 0.80);
            SetItem("4", "Ice Cubes", 250, 2.75);
            SetItem("4", "Ice Cubes", 500, 3.65);
        }
        private void 
        {
            weather.SetTemperature();
        }
        public void SetForecast()
        {
            weather.SetForecast();
        }
       
        public void Initialize()
        {
           
           
        }
        public void PrintName()
        {
            
            player.PrintName();
        }
        public void SetIceCubes()
        {
            player.SetIceCubes();
        }
           
            

        
    }
       
       
}

