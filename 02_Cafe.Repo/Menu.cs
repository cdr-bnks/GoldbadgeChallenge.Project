using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cafe.Repo
{
    //    The Menu Items:
    //A meal number, so customers can say "I'll have the #5"
    //A meal name
    //A description
    //A list of ingredients,
    //A price
    //Create a Menu Class with properties, constructors, and fields.
    public enum MealNumber
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
        public  MealNumber MealNumber { get; set; }
        public  string MealName { get; set; }
        public string Description { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public double Price { get; set; }
        public double Rating { get; set; }
        public System.DateTime MealTime { get; set; }
        public bool MealValue
        {
            get
            {
                


                switch (MealNumber)
                {
                    case MealNumber.kids_meal:
                    case MealNumber.single_meal:
                    case MealNumber.family_meal:
                    case MealNumber.a_la_carte:
                    case MealNumber.extra_veggie:
                    case MealNumber.extra_meat:
                    case MealNumber.extra_sides:
                    default:
                        return false;
                }
            }
        }

        public Menu(){ }

        public Menu(string mealName, MealNumber mealNumber, string description, List<Ingredients> ingredients, double price, double rating, System.DateTime mealTime)
        {
            MealName = mealName;
            MealNumber = mealNumber;
            Description = description;
            Ingredients = ingredients;
            Price = price;
            Rating = Rating;
            MealTime = mealTime;
        }

    }

    public class Ingredients
    {
        public string Spice { get; set; }
        public string Vegetable { get; set; }
        public double Measurement { get; set; }

        public Ingredients(){ }
        public Ingredients(string spice, string vegetable, double measurement)
        {
            Spice = spice;
            Vegetable = vegetable;
            Measurement = Measurement;
        }
    }
}
