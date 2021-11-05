using _08_Badge.ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Badges.App
{
    public class ProgramUI
    {
        private readonly BadgeRepo _badgeRepository = new BadgeRepo();

        public void Run()
        {
            SeedBadgeList();
            Menu();
        }

        private void Menu()
        {
            bool continueOn = true;
            while (continueOn)
            {
                Console.WriteLine("\t\t\t\t\t==============~Security Access~=========\t\\t\t\t\t" +
                    "Hello Security Adim, what would you like to do?\n" +
                    "1.) Create a new badge:\n" +
                    "2.) Edit a new badge:\n" +
                    "3.) List all badges:\n" +
                    "4.) Exit:");

                string sercurityInput = Console.ReadLine();
                switch (sercurityInput)
                {
                    case "1":
                        CreateBadgeToDirectory();
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        continueOn = false;
                        break;
                    default:
                        Console.WriteLine("Please stop sleeping on the console.");
                        break;
                }
                Console.WriteLine("Tap any key to proceed...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateBadgeToDirectory()
        { 
            Console.Clear();
            Badge badge = new Badge();
            badge.ListEachDoorName = new List<string>();
            Console.WriteLine($"Create a badge number\t" +
                $"What is the number on the Badge ID: {badge.BadgeID}");
            Console.WriteLine($"List a door that needs access to: {badge.BadgeID}\n" +
                $"_");
            badge.ListEachDoorName.Add(Console.ReadLine());

            Console.WriteLine($"Door successfully added tp Badge ID number: {badge.BadgeID} ");

            string AdamInput = Console.ReadLine().ToLower();
            if(AdamInput == "y")
            {
                Console.WriteLine($"List a door you need Access to: {badge.BadgeID}");
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();

            _badgeRepository.AddBadge(badge);
        }
        
        public void UpdateBadge()
        {
            Badge badge = new Badge();
           badge.ListEachDoorName = new List<string>();

            Console.Clear();
            Console.WriteLine("Please enter the badge number you would like to update: ");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"What is the BadgeNumber You would like to updeat{badge.BadgeID}\n" +
                $"\n" +
                $"1. Add a door\n" +
                $"2. Remove a door\n" +
                $"3. Return to menu\n");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    
                    AddDoorToEdit(badge.BadgeID);
                    break;
                case "2":
                    
                    RemoveDoorFromEdit(badge.BadgeID);
                    break;
                case "3":
                    Menu();
                    break;
            }
        }

        public void AddDoorToEdit(int badgeid)
        {
            Console.WriteLine("Enter a door to add:");
            string accessedDoor = Console.ReadLine();
            _badgeRepository.AddingDoorToBadge(badgeid, accessedDoor);

            Console.WriteLine("Door access has been added!");
           

            Console.ReadKey();

        }

        public void RemoveDoorFromEdit(int badgeid)
        {
            Console.WriteLine("Enter a door that you would like to remove:");
            string accessedDoor = Console.ReadLine();
            _badgeRepository.RemoveDoorEntry(badgeid, accessedDoor);

            Console.WriteLine("Door access has been revoked!");
            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }

        public void ListDoors()
        {
            Dictionary<int, List<string>> badge _badgeRepository.

            Console.WriteLine("=============");
            foreach (KeyValuePair<int, List<string>> badge in BadgeList)
            {
                Console.WriteLine($"Badge: {badge.Key}");

                foreach (string door in badge.Value)
                {
                    Console.WriteLine(door);
                }
                Console.WriteLine("=============");
            }
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadLine();

        }
        private void SeedBadgeList()
        {

        }
    }
}
