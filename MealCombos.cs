namespace DesignPatternDemo
{
	class MealCombo99 : MealBuilder
	{
        public MealCombo99()
        {
			meal = new Meal("Combo99");
        }
        public override void BuildBurger()
		{
			meal.SetMealItems("Burger", "Veg Burger");
        }

		public override void BuildDrink()
		{
			meal.SetMealItems("Drink", "Cola(Small)");
        }

		public override void BuildSideItem()
		{
			meal.SetMealItems("Side Item", "Cheese Cake");
        }

		public override void BuildToy()
		{
			meal.SetMealItems("Toy", "Toy Bike");
		}
	}

	class MealCombo199 : MealBuilder
	{
        public MealCombo199()
        {
			meal = new Meal("Combo199");
        }
        public override void BuildBurger()
		{
			meal.SetMealItems("Burger", "Chicken");
		}

		public override void BuildDrink()
		{
			meal.SetMealItems("Drink", "Cola(Medium)");
		}

		public override void BuildSideItem()
		{
			meal.SetMealItems("Side Item", "Brownie");
		}

		public override void BuildToy()
		{
			meal.SetMealItems("Toy", "Toy Car");
		}
	}

	class MealCombo299 : MealBuilder
	{
        public MealCombo299()
        {
			meal = new Meal("Combo299");
        }
        public override void BuildBurger()
		{
			meal.SetMealItems("Burger", "Double Cheeseburger");
		}

		public override void BuildDrink()
		{
			meal.SetMealItems("Drink", "Cola(Large)");
		}

		public override void BuildSideItem()
		{
			meal.SetMealItems("Side Item", "Muffins");
		}

		public override void BuildToy()
		{
			meal.SetMealItems("Toy", "Toy Plane");
		}
	}

	class MealCombo399 : MealBuilder
	{
        public MealCombo399()
        {
			meal = new Meal("Combo399");
        }
        public override void BuildBurger()
		{
			meal.SetMealItems("Burger", "Triple Cheeseburger");
		}

		public override void BuildDrink()
		{
			meal.SetMealItems("Drink", "Cola(Large)");
		}

		public override void BuildSideItem()
		{
			meal.SetMealItems("Side Item", "Chocolate Cake");
		}

		public override void BuildToy()
		{
			meal.SetMealItems("Toy", "Toy Train");
		}
	}
}
