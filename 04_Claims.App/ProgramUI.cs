using _05_Claims.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Claims.App
{
    class ProgramUI
    {
        private readonly ClaimRepo _claimRepository = new ClaimRepo();

        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu item:\n" +
                    "1.) Display all claims\n" +
                    "2.) Proceed with next claim\n" +
                    "3.) Add a new claim\n" +
                    "4.) Exit:");
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
                        Console.WriteLine("Unable to recognize this input please enter a number between 1-4.");
                        break;
                }
                Console.WriteLine("Tap any key to proceed...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void DisplayAllClaims()
        {

        }

        private void ProceedWithNextClaim()
        {

        }

        private void AddNewClaim()
        {

        }

    }
}
