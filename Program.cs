namespace DesignPatternDemo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MealBuilder mealBuilder;
			Director director = new Director();

			mealBuilder = new MealCombo99();
			director.Pack(mealBuilder);
			mealBuilder.Meal.Show();

			mealBuilder = new MealCombo199();
			director.Pack(mealBuilder);
			mealBuilder.Meal.Show();

			mealBuilder = new MealCombo299();
			director.Pack(mealBuilder);
			mealBuilder.Meal.Show();

			mealBuilder = new MealCombo399();
			director.Pack(mealBuilder);
			mealBuilder.Meal.Show();

		}
	}
}
