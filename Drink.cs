using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaufland
{
    class Drink : Restaurant
    {
        public void name()
        {
            List<String> names = new List<String>();
            names.Add("Water");
            names.Add("Coca-cola");
            names.Add("Beer");
            names.Add("Vodka");
            names.Add("Juice");
        }
        public void price()
        {
            String name = Console.ReadLine();
            double drinkprice = 0;
            if (name == "Water")
            {
                drinkprice += 2.00;
            }
            if (name == "Coca-cola")
            {
                drinkprice += 4.60;
            }
            if (name == "Beer")
            {
                drinkprice += 8.70;
            }
            if (name == "Vodka")
            {
                drinkprice += 12.65;
            }
            if (name == "Juice")
            {
                drinkprice += 3.45;
            }
            Console.WriteLine(drinkprice);
        }
    }
}
