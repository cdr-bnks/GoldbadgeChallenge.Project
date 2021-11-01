using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cafe.ClassLibrary
{
    //    The Menu Items:
    //A meal number, so customers can say "I'll have the #5"
    //A meal name
    //A description
    //A list of ingredients,
    //A price
    //Create a Menu Class with properties, constructors, and fields.
    public enum MealType
    {
        kids_meal = 1,
        single_meal,
        family_meal,
        a_la_carte,
        extra_veggie,
        extra_meat,
        extra_sides
    }
    public class Menu
    {
        public  MealType TypeOfMeal { get; set; }
        public  string MealName { get; set; }
        public string Description { get; set; }
        public List<Ingredient> Ingredient { get; set; }
        public double Price { get; set; }
        public System.DateTime MealTime { get; set; }
        public bool MealValue
        {
            get
            {
                


                switch (TypeOfMeal)
                {
                    case MealType.kids_meal:
                    case MealType.single_meal:
                    case MealType.family_meal:
                    case MealType.a_la_carte:
                    case MealType.extra_veggie:
                    case MealType.extra_meat:
                    case MealType.extra_sides:
                    default:
                        return false;
                }
            }
        }

        public Menu(){ }

        public Menu(string mealName, MealType mealNumber, string description, List<Ingredient> ingredient, double price, System.DateTime mealTime)
        {
            MealName = mealName;
            TypeOfMeal = mealNumber;
            Description = description;
            Ingredient = ingredient;
            Price = price;
            MealTime = mealTime;
        }

    }

    public class Ingredient
    {
        public string Spice { get; set; }
        public string Vegetable { get; set; }
        public string Meat { get; set; }
        public string Dairy { get; set; }
       

        public Ingredient(){ }
        public Ingredient(string spice, string vegetable, string meat, string dairy)
        {
            Spice = spice;
            Vegetable = vegetable;
            Meat = meat;
            Dairy = dairy;
           
        }
    }
}
