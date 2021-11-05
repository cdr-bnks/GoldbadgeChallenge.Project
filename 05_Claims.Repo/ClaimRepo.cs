using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Claims.Repo
{
    public class ClaimRepo
    {
        private readonly Queue<Claim> _claimDirectory = new Queue<Claim>();

        public Queue<Claim> SeeEveryClaim()
        {
            return _claimDirectory;
        }
        public bool MoveToAnotherClaim(string previousclaim, Claim nextClaim)
        {
            Claim formerClaim = GetClaimByID(previousclaim.Length);
                
            if(formerClaim != null)
            {
                formerClaim.ClaimID = nextClaim.ClaimID;
                formerClaim.ClaimType = nextClaim.ClaimType;
                formerClaim.Description = nextClaim.Description;
                formerClaim.ClaimAmount = nextClaim.ClaimAmount;
                formerClaim.DateOfIncident = nextClaim.DateOfIncident;
                formerClaim.DateOfClaim = nextClaim.DateOfClaim;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddClaimToList(Claim data)
        {
            _claimDirectory.Enqueue(data);
        }

        public  Claim GetClaimByID(int id)
        {
            foreach(Claim data in _claimDirectory)
            {
                if(data.ClaimID.ToString() == id.ToString())
                {
                    return data;
                }
            }
            return null;
        }

        public Claim PeekAtClaim()
        {
           return _claimDirectory.Peek();
        }

    }
}
