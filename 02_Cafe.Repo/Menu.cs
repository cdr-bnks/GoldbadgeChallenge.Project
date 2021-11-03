﻿using System;
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
        public MealType TypeOfMeal { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public double Price { get; set; }
        public string MealTime
        {
            get
            {
                string cafeHours = DateTime.Now.ToString("HH:mm:tt");
                switch (cafeHours)
                {
                    case "08:00:":
                    case "11:30:":
                        return "Breakfast";
                    case "12:00:":
                    case "14:30":
                        return "HappyHour";
                    case "15:00":
                    case "17:30":
                        return "Lunch";
                    case "18:00":
                    case "22:30":
                        return "Dinner";
                }
                return null;
            }
        }

        public Menu() { }

        public Menu(string mealName, MealType mealNumber, string description, string ingredient, double price)
        {
            MealName = mealName;
            TypeOfMeal = mealNumber;
            Description = description;
            Ingredient = ingredient;
            Price = price;
        }
    }
}
