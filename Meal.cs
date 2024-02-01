using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
	public class Meal
	{
		private string mealType;
		private Dictionary<string, string> mealItems = new Dictionary<string, string>();

        public Meal(string mealType)
		{
			this.mealType = mealType;
		}
        public string MealType { get => mealType; }

        public void SetMealItems(string item, string itemType)
		{
			mealItems.Add(item, itemType);
		}

		public void Show()
		{
            //Console.WriteLine($"The combo ordered is: {MealType}");
            Console.WriteLine($"Items: ");
			foreach( KeyValuePair<string, string> item in mealItems)
			{
                Console.WriteLine($"\t{item.Key} : {item.Value}");
            }
            Console.WriteLine();
        }
	}
}
