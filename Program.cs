using System;
using System.Security.Cryptography.X509Certificates;

namespace Kaufland
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food();
            Dessert dessert = new Dessert();
            Drink drink = new Drink();
            Console.WriteLine("Food: Potatoes, Fish, Steak, Eggs, Burger");
            Console.WriteLine("Dessert: Pizza, Cake, Chocolate, Ice-cream, Pancake");
            Console.WriteLine("Drink: Water, Coca-cola, Beer, Vodka, Juice");
            food.price();
            dessert.price();
            drink.price();
            
        }
    }
}
