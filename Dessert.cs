using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaufland
{
    class Dessert : Restaurant
    {
        public void name()
        {
            List<String> names = new List<String>();
            names.Add("Pizza");
            names.Add("Cake");
            names.Add("Chocolate");
            names.Add("Ice-cream");
            names.Add("Pancake");
        }
        public void price()
        {
            String name = Console.ReadLine();
            double dessertprice = 0;
            if (name == "Pizza")
            {
                dessertprice += 9.25;
            }
            if (name == "Cake")
            {
                dessertprice += 8.70;
            }
            if (name == "Chocolate")
            {
                dessertprice += 6.40;
            }
            if (name == "Ice-cream")
            {
                dessertprice += 7.25;
            }
            if (name == "Pancake")
            {
                dessertprice += 11.35;
            }
            Console.WriteLine(dessertprice);
        }
    }
}
