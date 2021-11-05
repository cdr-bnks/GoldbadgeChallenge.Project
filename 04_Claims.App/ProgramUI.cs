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

        public void Run()
        {
            SeedClaimList();
            Menu();
        }
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
                        ProcureAllClaims();
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

        private void ProcureAllClaims()
        {
            Console.Clear();
            Queue<Claim> claimlog = _claimRepository.SeeEveryClaim();
            Console.WriteLine("Claim ID:\t Type:\t Description:\t Amount:\t Date of Accident:\t Date of Claim:\t Valid");
            foreach (Claim claim in claimlog)
            {
                Console.WriteLine($"{claim.ClaimID}\t" +
                    $"{claim.ClaimType}\t" +
                    $"{claim.Description}\t" +
                    $"{claim.ClaimAmount}\t" +
                    $"{claim.DateOfIncident.ToShortDateString()}\t" +
                    $"{claim.DateOfIncident.ToShortDateString()}\t" +
                    $"{claim.IsValid}");
            }
            
        }

        private void ProceedWithNextClaim()
        {
            Console.Clear();
            Claim nextCLaim = _claimRepository.PeekAtClaim();

            Console.WriteLine($"{nextCLaim.ClaimID}\n" +
                $"{nextCLaim.ClaimType}\n" +
                $"{nextCLaim.Description}\n" +
                $"{nextCLaim.ClaimAmount}\n" +
                $"{nextCLaim.DateOfIncident}\n" +
                $"{nextCLaim.DateOfClaim}\n" +
                $"{nextCLaim.IsValid}");

            Console.WriteLine("Do you want to deal with this claim?: (y/n)");

              string input= Console.ReadLine().ToLower();
            if(input == "y")
            {
                Queue<Claim> claim = _claimRepository.SeeEveryClaim();
                claim.Dequeue();
                Console.WriteLine("You're claim has been successfully removed.");
            }
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
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

            Console.WriteLine("Enter the claim type:\n" +
                "1.) Medical:\n" +
                "2.) Insurance:\n" +
                "3.) Auto:\n" +
                "4.) Home:\n" +
                "5.) Theft:\n");
            string claim = Console.ReadLine();
            switch (claim.ToLower())
            {
                case "1":
                case "medical":
                    nextClaim.ClaimType = ClaimType.Medical;
                    break;
                case "2":
                case "insurance":
                    nextClaim.ClaimType = ClaimType.Insurance;
                    break;
                case "3":
                case "auto":
                    nextClaim.ClaimType = ClaimType.Auto;
                    break;
                case "4":
                case "home":
                    nextClaim.ClaimType = ClaimType.Home;
                    break;
                case "5":
                case "theft":
                    nextClaim.ClaimType = ClaimType.Theft;
                    break;
                default:
                    Console.WriteLine("Please press Number or claim type you see on the screen");
                    break;
            }

            Console.WriteLine("Enter the description for the claim:");
            nextClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the Amount of Damage:");
            string claimAmount = Console.ReadLine();
            nextClaim.ClaimAmount = double.Parse(claimAmount);
            

            Console.WriteLine($"Enter Date of Accident in this format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());


            Console.WriteLine($"Enter Date of claim in this exact format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

            _claimRepository.AddClaimToList(nextClaim);

            Queue<Claim> claimData = _claimRepository.SeeEveryClaim();
            foreach (Claim claimNum in claimData)
            {
                Console.WriteLine($"{claimNum.ClaimID}\t" +
                    $"{claimNum.ClaimType}\t" +
                    $"{claimNum.Description}\t" +
                    $"{claimNum.ClaimAmount}\t" +
                    $"{claimNum.DateOfIncident.ToShortDateString()}\t" +
                    $"{claimNum.DateOfIncident.ToShortDateString()}\t" +
                    $"{claimNum.IsValid}");
            }

        }

            private void SeedClaimList()
        {
            Console.Clear();
            Claim newClaimIndex = new Claim(1, ClaimType.Auto, "Car accident on 465.", 400.00, DateTime.Parse("4/25/18"), DateTime.Parse("4/27/18"));
            Claim newClaimIndex1 = new Claim(2, ClaimType.Home, "House Fire kitchen.", 4000.00, DateTime.Parse("4/11/18"), DateTime.Parse("4/12/18"));
            Claim newClaimIndex2 = new Claim(3, ClaimType.Theft, "Stolen Pancakes.", 4.00, DateTime.Parse("4/27/18"), DateTime.Parse("6/01/18"));
            Claim newClaimIndex3 = new Claim(4, ClaimType.Medical, "Fractured wrist from typing so much.", 77.00, DateTime.Parse("2/12/18"), DateTime.Parse("7/01/18"));

            _claimRepository.AddClaimToList(newClaimIndex);
            _claimRepository.AddClaimToList(newClaimIndex1);
            _claimRepository.AddClaimToList(newClaimIndex2);
            _claimRepository.AddClaimToList(newClaimIndex3);
        }

    }
}
