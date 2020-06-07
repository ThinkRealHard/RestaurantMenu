using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RestaurantMenu
{

	public class Menu
	{
		private List<MenuItem> foods;
		private Dictionary<string,double> price;
		public DateTime dateAdded { get; set; }

		public Menu(List<MenuItem> food, Dictionary<string,double> price, DateTime dateAdd)
		{
			this.foods = food;
			this.price = price;
			this.dateAdded = dateAdd;
		}

		public Menu(List<MenuItem> food, Dictionary<string,double> price)
			: this (food, price, DateTime.Now) { }


		public List<string> PrintMenu()
        {
			List<string> menuPrint = new List<string>();

			foreach (MenuItem food in foods)
            {
				menuPrint.Add("Appetizers\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food1 in foods) //loops through once to find apps
				{
					if (food1.Category == "appetizer")
					{
						menuPrint.Add("*************");
						menuPrint.Add($"{food1.Name}");
						menuPrint.Add($"{food1.Ingredients}");
						menuPrint.Add("*************");
					}
				}
				menuPrint.Add("\n");
				menuPrint.Add("Entrees\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food2 in foods) //loops through once for entrees
                {
					if (food2.Category == "entree")
                    {
						menuPrint.Add("*************");
						menuPrint.Add($"{food2.Name}");
						menuPrint.Add($"{food2.Ingredients}");
						menuPrint.Add("*************");
					}
                }
				menuPrint.Add("\n");
				menuPrint.Add("Desserts\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food3 in foods) //loops through once for desserts
				{
					if (food3.Category == "dessert")
					{
						menuPrint.Add("*************");
						menuPrint.Add($"{food3.Name}");
						menuPrint.Add($"{food3.Ingredients}");
						menuPrint.Add("*************");
					}
				}
				break;
			}
			return menuPrint;
        }

		public List<string> PrintNew()
        {
			List<string> menuPrint = new List<string>();

			foreach (MenuItem food in foods)
			{
				menuPrint.Add("Appetizers\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food1 in foods) //loops through once to find apps
				{
					if (food1.Category == "appetizer" && food1.isNew)
					{
						menuPrint.Add("*************");
						menuPrint.Add($"{food1.Name}");
						menuPrint.Add($"{food1.Ingredients}");
						menuPrint.Add("*************");
					}
				}
				menuPrint.Add("\n");
				menuPrint.Add("Entrees\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food2 in foods) //loops through once for entrees
				{
					if (food2.Category == "entree" && food2.isNew)
					{
						menuPrint.Add("*************");
						menuPrint.Add($"{food2.Name}");
						menuPrint.Add($"{food2.Ingredients}");
						menuPrint.Add("*************");
					}
				}
				menuPrint.Add("\n");
				menuPrint.Add("Desserts\n");
				menuPrint.Add("______________\n");
				foreach (MenuItem food3 in foods) //loops through once for desserts
				{
					if (food3.Category == "dessert" && food3.isNew)
					{
						menuPrint.Add("*************");
						menuPrint.Add($"{food3.Name}");
						menuPrint.Add($"{food3.Ingredients}");
						menuPrint.Add("*************");
					}
				}
				break;
			}
			return menuPrint;
		}
	}
}