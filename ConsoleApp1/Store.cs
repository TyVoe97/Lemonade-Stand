using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Store
    {
        double prices;
        string items;


        public Store()
        {

        }
        public void SetItems()
        {
            List<string> items = new List<string>();
            items.Add("Lemonade");
            items.Add(" Ice Cubes");
            items.Add("Sugar Cubes");
            items.Add("Paper Cups");
            foreach(string item in items)
            {
                Console.WriteLine(items);
            }

            double[] price = new double[3];
            {
                price[0] = 0.70;
                price[1] = 0.58;
                price[2] = 0.90;
                price[3] = 0.80; 

                for(double i = 0; i < price.Length; i++)
                {
                    Console.Write (price [i] + "," );
                }
            }

            
        }
    }
        
    
    
       

    
}
