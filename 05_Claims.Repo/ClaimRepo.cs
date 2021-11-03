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
        
       //See all claims:
       public Queue<Claim> SeeEveryClaim()
        {
            return _claimDirectory;
        }
        //Take care of next claim

        //Enter a new claim
        public void AddClaimToList(Claim data)
        {
            _claimDirectory.Enqueue(data);
        }

    }
}
