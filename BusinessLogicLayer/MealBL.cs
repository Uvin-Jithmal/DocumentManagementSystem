using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelerClasses.MealClasses;

namespace BusinessLogicLayer
{
   public class MealBL
    {
        private MealDA mealDA;
        
        //Get Meal Type
        public List<Meals> GetMealType()
        {
            mealDA = new MealDA();
            return mealDA.GetMealType();
        }
        //Insert Meals
        public int InsertMeals(Meals meals)
        {
            mealDA = new MealDA();
            return mealDA.InsertMeals(meals);
        }
        //Get Meal Type
        public List<Meals> GetMeal()
        {
            mealDA = new MealDA();
            return mealDA.GetMeal();
        }
    }
}
