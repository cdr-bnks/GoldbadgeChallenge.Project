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
        // use Lambda to check and see if it is contained Valid date
        private void ProcureAllClaims()
        {
            Console.Clear();
            Queue<Claim> claimData = _claimRepository.SeeEveryClaim();
            Claim index = claimData.Peek();
            foreach (Claim state in claimData)
            {
                int claimID = 0;
                claimID++;
                Console.WriteLine($"Claim ID: {state.ClaimID}\t" +
                    $"Type: {state.ClaimType}\t" +
                    $"Description: {state.Description}\t" +
                    $"Amount: {state.ClaimAmount}\t" +
                    $"Date of Incident: {state.DateOfIncident}\t" +
                    $"Date of Claim: { state.DateOfClaim}\t" +
                    $"Is procured claim valid: {state.IsValid}\t" +
                    $"Do you want to take this claim? (y/n)");
                if(index.DateOfClaim >= state.DateOfIncident)
                {
                    for(int c = 0; c < 30; c++)
                    {
                        Console.WriteLine(claimID);
                    }
                    bool 
                    
                }
               
            }
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

            Console.WriteLine("Enter the claim type:\n" +
                "1.) Medical:\n" +
                "2.) Insurance:\n" +
                "3.) Auto:\n" +
                "4.) Home:\n" +
                "5.) Theft:\n");
            string claim = Console.ReadLine();
          //switch case
            //figure out a way to dislpay the ClaimType enums:
           

            Console.WriteLine("Enter the description for the claim:");
            nextClaim.Description = Console.ReadLine();

            Console.WriteLine("Enter the Amount of Damage:");
            string claimAmount = Console.ReadLine();
            nextClaim.ClaimAmount = double.Parse(claimAmount);

            Console.WriteLine($"Enter Date of Accident in this format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfIncident = DateTime.Parse(Console.ReadLine());


            Console.WriteLine($"Enter Date of claim in this exact format:{DateTime.Now.ToString("d")}");
            nextClaim.DateOfClaim = DateTime.Parse(Console.ReadLine());

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

            Queue<Claim> claimData = _claimRepository.SeeEveryClaim();
            foreach (Claim state in claimData)
            {
                Console.WriteLine($"Claim ID: {state.ClaimID}\t" +
                    $"Type: {state.ClaimType}\t" +
                    $"Description: {state.Description}\t" +
                    $"Amount: {state.ClaimAmount}\t" +
                    $"Date of Incident: {state.DateOfIncident}\t" +
                    $"Date of Claim: { state.DateOfClaim}\t" +
                    $"Is procured claim valid: {state.IsValid}\t" +
                    $"Do you want to take this claim? (y/n)");
            }

            _claimRepository.AddClaimToList(nextClaim);
        }

        private void SeedClaimList()
        {
            Console.Clear();
            Claim newClaimIndex = new Claim(1, ClaimType.Auto, "Car accident on 465.", 400.00, DateTime.Parse("4/25/18"), DateTime.Parse("4/27/18"),true);
            Claim newClaimIndex1 = new Claim(2, ClaimType.Home, "House Fire kitchen.", 4000.00, DateTime.Parse("4/11/18"), DateTime.Parse("4/12/18"),true);
            Claim newClaimIndex2 = new Claim(3, ClaimType.Theft, "Stolen Pancakes.", 4.00, DateTime.Parse("4/27/18"), DateTime.Parse("6/01/18"),false);
            Claim newClaimIndex3 = new Claim(4, ClaimType.Medical, "Fractured wrist from typing so much.", 77.00, DateTime.Parse("2/12/18"), DateTime.Parse("7/01/18"),false);
        }

    }
}
