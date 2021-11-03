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
                        DisplayAllClaims();
                        break;
                    case "2":
                        ProceedWithNextClaim();
                        break;
                    case "3":
                        AddNewClaim();
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
        // use Lambda to check and see if it is contained Valid date
        private void DisplayAllClaims()
        {

        }

        private void ProceedWithNextClaim()
        {

        }

        private void AddNewClaim()
        {
            Console.Clear();
            Claim nextClaim = new Claim();


            Console.WriteLine("Add claim data to the directory.\n" +
                "Please enter the claim ID:");
            string claimInt = Console.ReadLine();

            try
            {
                int claimID = int.Parse(claimInt);
                nextClaim.ClaimID = claimID;
            }
            catch
            {
                Console.WriteLine("Please press a valid ID Number:");
            }

            /* if (claimInt.Length <= 100)
             {
                 for (int c = 0; c < 6; c++)
                 {
                     nextClaim.ToString;
                 }
             } */

            Console.WriteLine("Enter the claim type:");
            string claim = Console.ReadLine();
            Claim data = _claimRepository.GetClaimByID(claim.Length);

            if(data != null)
            {
                Console.WriteLine($"1.) Medical{data.ClaimType.ToString()}\n" +
                    $"2.) Insurance{data.ClaimType.ToString()}\n" +
                    $"3.) Auto{data.ClaimType.ToString()}\n" +
                    $"4.) Home{data.ClaimType.ToString()}\n" +
                    $"5.) Theft{data.ClaimType.ToString()}");
            }
            else
            {
                Console.WriteLine("No Type by that name:");
            }

            Console.WriteLine("Enter the description for the claim:");
            nextClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the Amount of Damage:");
            string claimAmount = Console.ReadLine();
            nextClaim.ClaimAmount = double.Parse(claimAmount);

            Console.WriteLine($"Enter Date of Accident in this format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfIncident = Console.ReadLine();

            Console.WriteLine($"Enter Date of claim in this exact format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfClaim = Console.ReadLine();

            Console.WriteLine("Is the following claim valid?:\n" +
                "Enter (Y/N):");
            string claiminput = Console.ReadLine().ToLower();
            if(claiminput == "y")
            {
                nextClaim.IsValid = true;
            }
            else
            {
                nextClaim.IsValid = false;
            }

            _claimRepository.AddClaimToList(nextClaim);
        }
    }
}
