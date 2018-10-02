using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Recipe
    {

        public int iceCubes = 4;
        public int sugarCubes = 3;
        public int lemons = 2;
        public int paperCups = 1;
        int Id;
        string description;
        int Quantity;
        double price;

        public Recipe()
        {


        }

        public void SetPaperCups()
        {


            Console.WriteLine("Press 1 for Ice Cubes");
            int paperCups = int.Parse(Console.ReadLine());
            if (paperCups == 1)
            {
               string ("1", "Paper Cups", 25, 1.10);
               string ("1", "Paper Cups", 75, 1.84);
               string ("1", "Paper Cups", 100, 3.22);
            }
            Console.ReadLine();

        }
        public void SetLemons()
        {
            Console.WriteLine("Press 2 for Lemons");
            int id = int.Parse(Console.ReadLine());
            if (id == 2)
            {

            }
            Console.ReadLine();
        }
        public void SetSugarCubes()
        {
            Console.WriteLine("Press 3 for Sugar Cubes ");
            int id = int.Parse(Console.ReadLine());
            if (id == 3)
            {

            }
            Console.ReadLine();
        }
        public void SetIceCubes()
        {
            Console.WriteLine("Press 4 fo Ice Cubes");
            int id = int.Parse(Console.ReadLine());
            if (id == 4)
            {

            }
            Console.ReadLine();
        }
        private void SetRecipe(int id, string desc, int quantity, double price)
        {
            Recipe recipe = new Recipe();
            recipe.Id = id;
            recipe.description = desc;
            recipe.Quantity = quantity;
            recipe.price = price;
        }
    }
}
