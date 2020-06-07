using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace RestaurantMenu
{

	public class MenuItem
	{
		public string Category { get; set; }
		public string Name { get; set; }
		public string Ingredients { get; set; }

		public bool isNew { get; set; }

		public MenuItem(string cat, string name, string ingred, bool brandNew)
		{
			this.Category = cat;
			this.Name = name;
			this.Ingredients = ingred;
			this.isNew = brandNew;
		}

		public MenuItem(string cat, string name, string ingred)
		: this(cat, name, ingred, true) { }
	}
}