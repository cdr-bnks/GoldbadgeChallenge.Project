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

        private void CreateNewMenuItem() { }
        private void Deleteitems() { }
        private void GetItemList() { }


        private void SeedItemList() { }
    }
}
