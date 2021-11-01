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
        public void Run()
        {
            SeedItemList();
            RunMenu();
        }
        public void RunMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select an option on the menu\n\n" +
                    "1.) Create new menu items:\n" +
                    "2.) Delete items:\n" +
                    "3.) Recieve a list of all items\n " +
                    "4.) Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        DeleteItem();
                        break;
                    case "3":
                        break;
                    case "4":
                        keepRunning = false;
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
            Menu newMenu = new Menu();
            Console.WriteLine("Enter the meal name for the menu:");
            newMenu.MealName = Console.ReadLine();

            Console.WriteLine("Enter a order number (1-7):\n" +
                "1.) kids meal\n" +
                "2.) single meal\n" +
                "3.) family meal\n" +
                "4.) a la carte\n" +
                "5.) extra veggie\n" +
                "6.) extra meat\n" +
                "7.) extra sides");

            string mealAsWord = Console.ReadLine();
            int mealAsNumber = int.Parse(mealAsWord);
            newMenu.TypeOfMeal = (MealType)mealAsNumber;

            switch (mealAsWord.ToLower())
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
                    Console.WriteLine("Please enter a valid response");
                    break;
            }
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
