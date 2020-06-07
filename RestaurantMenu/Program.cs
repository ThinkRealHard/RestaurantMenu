using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem mozzSticks = new MenuItem("appetizer", "Mozzarella Sticks", "Breading, Mozzarella", false);
            MenuItem pizza = new MenuItem("entree", "Cheese Pizza", "Wheat Dough, Mozzarella, Tomato Sauce", false);
            MenuItem iceCream = new MenuItem("dessert", "Chocolate Ice Cream", "Chocolate, Sugar, Cream");
            List<MenuItem> foods = new List<MenuItem>();
            Dictionary<string, double> foodsPrice = new Dictionary<string, double>();
            foodsPrice.Add("mozzSticks", 5.00);
            foodsPrice.Add("pizza", 12.00);
            foodsPrice.Add("iceCream", 7.00);
            foods.Add(mozzSticks);
            foods.Add(pizza);
            foods.Add(iceCream);
            Menu restMenu = new Menu(foods, foodsPrice, DateTime.Now);

            while(true)
            {
                Console.WriteLine("Welcome to the Restaurant!\n");
                Console.WriteLine("Please Choose - 1) View the Entire Menu\n2)View Only the Items New to the Menu!\n(Type Any Other Number to Exit)");
                int choice = int.Parse(Console.ReadLine());
                if(choice == 1)
                {
                    List<string> printer = restMenu.PrintMenu();
                    foreach (string line in printer)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n\nMenu last updated: " + restMenu.dateAdded);
                }
                else if (choice == 2)
                {
                    List<string> printer = restMenu.PrintNew();
                    foreach (string line in printer)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n\nMenu last updated: " + restMenu.dateAdded);
                }
                else
                {
                    break;
                }
            }

        }
    }
}
