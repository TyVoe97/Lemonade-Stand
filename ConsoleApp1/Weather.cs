using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Weather
    {

        int temperature;
        string forecast;
        string Initializing;
        public Weather()
        {


        }
        public void SetTemperature()
        {
            Random random = new Random();
            temperature = random.Next(50, 99);
            System.Console.WriteLine(temperature);

        }
        public void SetForecast()
        {
            Random random = new Random();
            int weather = random.Next(1, 5);
            if (weather == 1)
            {
                forecast = "rain";
            }
            else if (weather == 2)
            {
                forecast = "sunny";
            }
            else if (weather == 3)
            {
                forecast = "cloudy";
            }
            else if (weather == 4)
            {
                forecast = "clear + sunny";
            }
        }
    }
}
    
