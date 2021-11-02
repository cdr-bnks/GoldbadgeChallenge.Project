using _02_Cafe.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe.App
{
    class ProgramUI
    {
        private MenuRepo _cafeRepo = new MenuRepo();
       
        /*public void Run()
        {
            SeedItemList();
            RunMenu();
        }*/
        public void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option on the menu:\n\n" +
                    "1.) Create new menu items:\n" +
                    "2.) Delete items:\n" +
                    "3.) Look at Meal Hours\n" +
                    "4.) Recieve a list of all items\n " +
                    "5.) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;
                    case "2":
                       
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Enter a valid number.");
                        break;
                }
                Console.WriteLine("Press any key to contiue...");
                Console.ReadKey();
                Console.Clear();

            }
        }

        private void CreateNewMenuItem()
        {
            Console.Clear();
            Menu newMenu = new Menu();
            Console.WriteLine("Enter the meal name for the menu:");
            newMenu.MealName = Console.ReadLine();

            Console.WriteLine("\nEnter an order number (1-7):\n" +
                "1.) kids meal\n" +
                "2.) single meal\n" +
                "3.) family meal\n" +
                "4.) a la carte\n" +
                "5.) extra veggie\n" +
                "6.) extra meat\n" +
                "7.) extra sides");

            string mealAsWord = Console.ReadLine();
            try
            {
                int mealAsNumber = int.Parse(mealAsWord);
                newMenu.TypeOfMeal = (MealType)mealAsNumber;
            }
            catch
            {
                Console.WriteLine("Select a valid number between (1-7)");
            }
            
            switch (mealAsWord.ToUpper())
            {
                case "1":
                case "kids meal":
                    newMenu.TypeOfMeal = MealType.kids_meal;
                    break;
                case "2":
                case "single meal":
                    newMenu.TypeOfMeal = MealType.single_meal;
                    break;
                case "3":
                case "family meal":
                    newMenu.TypeOfMeal = MealType.family_meal;
                    break;
                case "4":
                case "a la carte":
                    newMenu.TypeOfMeal = MealType.a_la_carte;
                    break;
                case "5":
                case "extra veggie":
                    newMenu.TypeOfMeal = MealType.extra_veggie;
                    break;
                case "6":
                case "extra meat":
                    newMenu.TypeOfMeal = MealType.extra_meat;
                    break;
                case "7":
                case "extra sides":
                    newMenu.TypeOfMeal = MealType.extra_sides;
                    break;
                default:
                    Console.WriteLine("Please enter a valid response...");
                    break;

                    
            }
            
            Console.WriteLine("\nEnter in the description for the menu:");
            newMenu.Description = Console.ReadLine();

            Console.WriteLine("\nEnter in the List of ingredients:");
            newMenu.Ingredient = Console.ReadLine();

            Console.WriteLine("\nEnter the Price for the menu:");
            string mangerPrice = Console.ReadLine();
            newMenu.Price = double.Parse(mangerPrice);
            
            _cafeRepo.AddItemsToMenuList(newMenu);
        }
       
        private void DeleteItem()
        {
            //List<Menu> itemlist = _
        }
        private void GetItemList() { }


        private void SeedItemList() { }
    }
}
