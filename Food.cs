using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaufland 
{
    class Food : Restaurant
    {
        public void name()
        {
            List<String> names = new List<String>();
            names.Add("Potatoes");
            names.Add("Fish");
            names.Add("Steak");
            names.Add("Eggs");
            names.Add("Burger");
        }
        public void price()
        {
            String name = Console.ReadLine();
            double foodprice = 0;
            if (name == "Potatoes")
            {
                foodprice += 10.50;
            }
            if (name == "Fish")
            {
                foodprice += 14.60;
            }
            if (name == "Steak")
            {
                foodprice += 17.20;
            }
            if (name == "Eggs")
            {
                foodprice += 8.45;
            }
            if (name == "Burger")
            {
                foodprice += 13.60;
            }
            Console.WriteLine(foodprice);
        }
    }
}
