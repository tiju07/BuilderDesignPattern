using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
	abstract class MealBuilder
	{
        protected Meal meal;
        public Meal Meal { get => meal; }

        public abstract void BuildBurger();
        public abstract void BuildSideItem();
        public abstract void BuildDrink();
        public abstract void BuildToy();
    }
}
