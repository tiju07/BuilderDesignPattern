using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
	class Director
	{
		public void Pack(MealBuilder mealBuilder)
		{
			mealBuilder.BuildBurger();
			mealBuilder.BuildDrink();
			mealBuilder.BuildSideItem();
			mealBuilder.BuildToy();
            Console.WriteLine($"Order for the combo \"{mealBuilder.Meal.MealType}\" was packed and delivered!");
        }
	}
}
